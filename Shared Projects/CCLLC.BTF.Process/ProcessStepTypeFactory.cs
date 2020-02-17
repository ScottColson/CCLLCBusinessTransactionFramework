using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class ProcessStepTypeFactory : IProcessStepTypeFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.ProcessStepTypeFactory";

        protected IDeferredActivator Activator { get; }

        public ProcessStepTypeFactory(IDeferredActivator activator)
        {
            this.Activator = activator ?? throw new ArgumentNullException("activator is null.");
        }

        public IProcessStepType CreateStepType(IProcessExecutionContext executionContext, IRecordPointer<Guid> processStepTypeId, string name, bool isConditional, string implementationAssemblyName, string implementationClassName, TimeSpan? cacheTimeout = null)
        {
            string cacheKey = null;
            if (executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = CACHE_KEY + processStepTypeId.Id.ToString();
            }

            if (executionContext.Cache.Exists(cacheKey))
            {
                return executionContext.Cache.Get<IProcessStepType>(cacheKey);
            }
           

            if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("processStepTypeName is null"); }
            if (string.IsNullOrEmpty(implementationAssemblyName)) { throw new ArgumentNullException("implementationAssemblyName is null,"); }
            if (string.IsNullOrEmpty(implementationClassName)) { throw new ArgumentNullException("implementationClassName is null"); }

            try
            {
                var stepType = Activator.InstantiateClass<IProcessStepType>(processStepTypeId.Id, name, implementationAssemblyName, implementationClassName);
                stepType.IsConditional = isConditional;

                if (cacheKey != null)
                {
                    executionContext.Cache.Add<IProcessStepType>(cacheKey, stepType, cacheTimeout.Value);
                }

                return stepType;
            }
            catch (ArgumentNullException ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeInvalid, ex);
            }
            catch (Exception ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeActivationFailure, ex);
            }
        }
    }
}
