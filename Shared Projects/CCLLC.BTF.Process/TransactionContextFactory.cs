using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class TransactionContextFactory : ITransactionContextFactory
    {

        private const string CACHE_KEY = "CCLLC.BTF.Process.TransactionContextFactory";

        protected ICustomerFactory CustomerFactory { get; }
        protected ITransactionDataConnector DataConnector { get; }

        public TransactionContextFactory(ITransactionDataConnector dataConnector, ICustomerFactory customerFactory)
        {
            this.DataConnector = dataConnector;
            this.CustomerFactory = customerFactory;
        }
       
        public ITransactionContext CreateTransactionContext(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionContextId, TimeSpan? cacheTimeout = null)
        {
            string cacheKey = null;
            if (executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = CACHE_KEY + transactionContextId.Id.ToString();
            }

            if (executionContext.Cache.Exists(cacheKey))
            {
                return executionContext.Cache.Get<ITransactionContext>(cacheKey);
            }

            var record = DataConnector.GetTransactionContextRecord(executionContext.DataService, transactionContextId);

            var customer = CustomerFactory.CreateCustomer(executionContext, record.CustomerId, cacheTimeout);

            var transactionContext = new TransactionContext(record, customer);

            if (cacheKey != null)
            {
                executionContext.Cache.Add<ITransactionContext>(cacheKey, transactionContext, cacheTimeout.Value);
            }

            return transactionContext;

        }
    }
}
