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

        public ProcessStepFactory(IParameterSerializer parameterSerializer)
        {
            this.ParameterSerializer = parameterSerializer ?? throw new ArgumentNullException("parameterSerializer is null");
        }

        public IProcessStep CreateProcessStep(IProcessExecutionContext executionContext, IRecordPointer<Guid> stepId, string name, IRecordPointer<Guid> transactionProcessPointer, IProcessStepType processStepType, string parameters, IRecordPointer<Guid> subsequentStepPointer, IEnumerable<IAlternateBranch> alternateBranches, IEnumerable<IChannel> authorizedChannels, IEnumerable<IStepRequirement> validationRequirements, TimeSpan? cacheTimeout = null)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (stepId is null) throw new ArgumentNullException("stepId");

            string cacheKey = null;
            if (executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = CACHE_KEY + stepId.Id.ToString();
            }

            if (cacheKey != null)
            {
                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<IProcessStep>(cacheKey);
                }
            }           

            try
            {

                if (transactionProcessPointer == null) throw new ArgumentNullException("transactionProcessPointer.");
                if (processStepType == null) throw new ArgumentNullException("processStepType");
                if (authorizedChannels == null) { throw new ArgumentNullException("authorizedChannels"); }
                if (validationRequirements == null) { throw new ArgumentNullException("validationRequirements"); }
                if (alternateBranches == null) { throw new ArgumentNullException("alternateBraches"); }

                var serializedParameter = this.ParameterSerializer.CreateParamters(parameters);
                processStepType.ValidateStepParameters(executionContext, serializedParameter);

                IProcessStep step = new ProcessStep(stepId, name, transactionProcessPointer, processStepType, serializedParameter,subsequentStepPointer, alternateBranches, authorizedChannels, validationRequirements);
                              
                if (cacheKey != null)
                {
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
