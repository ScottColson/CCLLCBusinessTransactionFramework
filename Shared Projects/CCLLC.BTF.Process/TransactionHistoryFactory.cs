using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;   

    public class TransactionHistoryFactory : ITransactionHistoryFactory
    {        
        protected IStepHistoryDataConnector DataConnector { get; }

        public TransactionHistoryFactory(IStepHistoryDataConnector dataConnector)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
        }

       
        public ITransactionHistory CreateTransactionHistory(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            
            var records = DataConnector.QueryTransactionStepHistory(executionContext.DataService, transaction);

            return new TransactionHistory(this.DataConnector, transaction, records);
        }
    }
}
