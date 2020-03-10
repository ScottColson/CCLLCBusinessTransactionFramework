using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class ProcessStepFactory : IProcessStepFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.ProcessStepFactory";
       
        protected IParameterSerializer ParameterSerializer { get; }
        protected IProcessSettingsFactory SettingsFactory { get; }

        public ProcessStepFactory(IProcessSettingsFactory settingsFactory, IParameterSerializer parameterSerializer)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.ParameterSerializer = parameterSerializer ?? throw new ArgumentNullException("parameterSerializer");
        }

        public IProcessStep CreateProcessStep(IProcessExecutionContext executionContext, IRecordPointer<Guid> stepId, string name, IRecordPointer<Guid> transactionProcessPointer, IProcessStepType processStepType, string parameters, IRecordPointer<Guid> subsequentStepPointer, IEnumerable<IAlternateBranch> alternateBranches, IEnumerable<IChannel> authorizedChannels, IEnumerable<IStepRequirement> validationRequirements, bool useCache = true)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (stepId is null) throw new ArgumentNullException("stepId");

                useCache = useCache && executionContext.Cache != null;

                string cacheKey = null;                
                if (useCache)
                {
                    cacheKey = CACHE_KEY + stepId?.Id.ToString();
                   
                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        return executionContext.Cache.Get<IProcessStep>(cacheKey);
                    }
                }

                if (transactionProcessPointer == null) throw new ArgumentNullException("transactionProcessPointer.");
                if (processStepType == null) throw new ArgumentNullException("processStepType");
                if (authorizedChannels == null) { throw new ArgumentNullException("authorizedChannels"); }
                if (validationRequirements == null) { throw new ArgumentNullException("validationRequirements"); }
                if (alternateBranches == null) { throw new ArgumentNullException("alternateBraches"); }

                var serializedParameter = this.ParameterSerializer.CreateParamters(parameters);
                processStepType.ValidateStepParameters(executionContext, serializedParameter);

                IProcessStep step = new ProcessStep(stepId, name, transactionProcessPointer, processStepType, serializedParameter, subsequentStepPointer, alternateBranches, authorizedChannels, validationRequirements);

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    var cacheTimeout = settings.ProcessStepCacheTimeout;

                    executionContext.Cache.Add<IProcessStep>(cacheKey, step, cacheTimeout.Value);
                }

                return step;

            }
            catch (Exception ex)
            {
                throw ex;
            }
                        
        }

       
    }
}
