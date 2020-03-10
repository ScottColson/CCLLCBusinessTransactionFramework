using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public class TransactionRequirementFactory : ITransactionRequirementFactory
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Process.TransactionRequirementFactory";

        protected ILogicEvaluatorFactory EvaluatorFactory { get; }
        protected IProcessSettingsFactory SettingsFactory { get; }

        public TransactionRequirementFactory(IProcessSettingsFactory settingsFactory, ILogicEvaluatorFactory evaluatorFacotry)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.EvaluatorFactory = evaluatorFacotry ?? throw new ArgumentNullException("evaluatorFactory");
        }

        public ITransactionRequirement CreateRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

                string cacheKey = null;                

                if (useCache)
                {
                    cacheKey = CACHE_KEY + requirementId.ToString();                    

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        return executionContext.Cache.Get<ITransactionRequirement>(cacheKey);
                    }
                }
                
                var evaluator = EvaluatorFactory.CreateEvaluator(executionContext, requirementId, evaluatorType, parameters, useCache);
                var requirement = new TransactionRequirement(requirementId.RecordType,requirementId.Id, name, requirementType, transactionTypeId, evaluator, waiverRoles);
                
                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    var cacheTimeout = settings.TransactionRequirementCacheTimeout;

                    executionContext.Cache.Add<ITransactionRequirement>(cacheKey, requirement, cacheTimeout.Value);
                }

                return requirement;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public ITransactionRequirement CreateRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
