using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class ProcessStepTypeFactory : IProcessStepTypeFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.ProcessStepTypeFactory";

        protected IDeferredActivator Activator { get; }
        protected IProcessSettingsFactory SettingsFactory { get; }

        public ProcessStepTypeFactory(IProcessSettingsFactory settingsFactory, IDeferredActivator activator)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.Activator = activator ?? throw new ArgumentNullException("activator is null.");
        }

        public IProcessStepType CreateStepType(IProcessExecutionContext executionContext, IRecordPointer<Guid> processStepTypeId, string name, bool isConditional, string implementationAssemblyName, string implementationClassName, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

                string cacheKey = null;
                TimeSpan? cacheTimeout = null;

                if (useCache)
                {
                    cacheKey = CACHE_KEY + processStepTypeId.Id.ToString();

                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    cacheTimeout = settings.ProcessStepTypeCacheTimeout;

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        return executionContext.Cache.Get<IProcessStepType>(cacheKey);
                    }
                }
                
                if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("processStepTypeName is null"); }
                if (string.IsNullOrEmpty(implementationAssemblyName)) { throw new ArgumentNullException("implementationAssemblyName is null,"); }
                if (string.IsNullOrEmpty(implementationClassName)) { throw new ArgumentNullException("implementationClassName is null"); }
                
                var stepType = Activator.InstantiateClass<IProcessStepType>(processStepTypeId.RecordType, processStepTypeId.Id, name, implementationAssemblyName, implementationClassName);
                stepType.IsConditional = isConditional;

                if (useCache)
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
