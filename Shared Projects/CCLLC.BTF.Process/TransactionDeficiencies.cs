using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class TransactionDeficiencies : List<IRequirementDeficiency>, ITransactionDeficiencies
    {
        private ITransaction Transaction { get; }
        private ITransactionDataConnector DataConnector {get;}

        public TransactionDeficiencies(ITransactionDataConnector dataConnector, ITransaction transaction, IList<IRequirementDeficiency> deficiencies) 
            : base(deficiencies)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.Transaction = transaction ?? throw new ArgumentNullException("transaction");
        }

        public IRequirementDeficiency CreateDeficiency(IProcessExecutionContext executionContext, ITransactionRequirement requirement)
        {
            throw new NotImplementedException();
        }

        public IRequirementDeficiency GetCurrentRequirementDeficiency(ITransactionRequirement requirement)
        {
            throw new NotImplementedException();
        }       

        public void RemoveDeficiency(IProcessExecutionContext executionContext, ITransactionRequirement requirement)
        {
            throw new NotImplementedException();
        }       
    }
}
