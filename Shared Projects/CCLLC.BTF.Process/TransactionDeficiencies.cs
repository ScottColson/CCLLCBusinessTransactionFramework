using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class TransactionDeficiencies : List<IRequirementDeficiency>, ITransactionDeficiencies
    {
        private ITransaction Transaction { get; }
        private ITransactionDataConnector DataConnector { get; }

        public TransactionDeficiencies(ITransactionDataConnector dataConnector, ITransaction transaction, IList<IRequirementDeficiency> deficiencies)
            : base(deficiencies)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.Transaction = transaction ?? throw new ArgumentNullException("transaction");
        }

        public IRequirementDeficiency CreateDeficiency(IProcessExecutionContext executionContext, IRequirement requirement)
        {
            var record = DataConnector.CreateDeficiencyRecord(executionContext.DataService, requirement.Name, this.Transaction, requirement);
            var deficiency = new RequirementDeficiency(requirement, record.Status, null, null);
            base.Add(deficiency);
            return deficiency;
        }

        public IRequirementDeficiency GetCurrentRequirementDeficiency(IRequirement requirement)
        {
            return this.Where(r => r.Requirement.Id == requirement.Id && r.Status != eDeficiencyStatusEnum.Cleared).FirstOrDefault();
        }

        public void ClearDeficiency(IProcessExecutionContext executionContext, IRequirement requirement)
        {
            var deficiency = GetCurrentRequirementDeficiency(requirement);
            if (deficiency.Status != eDeficiencyStatusEnum.Waived)
            {
                DataConnector.UpdateDeficiencyRecordStatus(executionContext.DataService, deficiency, eDeficiencyStatusEnum.Cleared);
                base.Remove(deficiency);
            }

        }
    }
}
