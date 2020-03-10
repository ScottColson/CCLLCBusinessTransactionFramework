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
        protected IProcessSettingsFactory SettingsFactory { get; }

        public TransactionContextFactory(IProcessSettingsFactory settingsFactory, ITransactionDataConnector dataConnector, ICustomerFactory customerFactory)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory");
        }
       
        public ITransactionContext CreateTransactionContext(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionContextId, bool useCache = true)
        {
            useCache = useCache && executionContext.Cache != null;

            string cacheKey = null;
            if (useCache)
            {
                cacheKey = CACHE_KEY + transactionContextId.Id.ToString();

                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<ITransactionContext>(cacheKey);
                }
            }
            

            var record = DataConnector.GetTransactionContextRecord(executionContext.DataService, transactionContextId);

            var customer = CustomerFactory.CreateCustomer(executionContext, record.CustomerId, useCache);

            var transactionContext = new TransactionContext(record, customer);

            if (useCache)
            {
                var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                var cacheTimeout = settings.TransactionContextCacheTimeout;

                executionContext.Cache.Add<ITransactionContext>(cacheKey, transactionContext, cacheTimeout.Value);
            }

            return transactionContext;

        }
    }
}
