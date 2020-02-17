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

        public TransactionRequirementFactory(ILogicEvaluatorFactory evaluatorFacotry)
        {
            this.EvaluatorFactory = evaluatorFacotry;
        }

        public ITransactionRequirement CreateRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, TimeSpan? cacheTimeout = null)
        {
            try
            {

                string cacheKey = null;
                
                if (executionContext.Cache != null && cacheTimeout != null)
                {
                    cacheKey = CACHE_KEY + requirementId.ToString();
                }

                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<ITransactionRequirement>(cacheKey);
                }

                var evaluator = EvaluatorFactory.CreateEvaluator(executionContext, requirementId, evaluatorType, parameters, cacheTimeout);
                var requirement = new TransactionRequirement(requirementId.RecordType,requirementId.Id, name, requirementType, transactionTypeId, evaluator, waiverRoles);


                if (cacheKey != null)
                {
                    executionContext.Cache.Add<ITransactionRequirement>(cacheKey, requirement, cacheTimeout.Value);
                }

                return requirement;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, TimeSpan? cacheTimeout = null)
        {
            throw new NotImplementedException();
        }

        public ITransactionRequirement CreateRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, TimeSpan? cacheTimeout = null)
        {
            throw new NotImplementedException();
        }

        public ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, TimeSpan? cacheTimeout = null)
        {
            throw new NotImplementedException();
        }
    }
}
