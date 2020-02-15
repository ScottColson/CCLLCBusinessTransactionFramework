using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class CustomerFactory : ICustomerFactory
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Platorm.CustomerFactory";

        protected IPlatformDataConnector DataConnector { get; }

        public ICustomer CreateCustomer(IProcessExecutionContext executionContext, IRecordPointer<Guid> customerId, TimeSpan? cacheTimeout = null)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (customerId is null) throw new ArgumentNullException("customerId");

                string cacheKey = null;
                if (executionContext.Cache != null && cacheTimeout != null)
                {
                    cacheKey = CACHE_KEY + customerId.RecordType + customerId.Id.ToString();
                }

                if (executionContext.Cache.Exists(cacheKey))
                {
                    executionContext.Trace("Returning Customer from Cache.");
                    return executionContext.Cache.Get<ICustomer>(cacheKey);
                }

                var customerRecord = DataConnector.GetCustomerRecord(executionContext.DataService, customerId);

                var customerClasses = DataConnector.GetCustomerClasses(executionContext.DataService, customerId);


                var customer = new Customer(customerRecord, customerClasses);

                if(cacheKey != null)
                {
                    executionContext.Cache.Add<ICustomer>(cacheKey, customer, cacheTimeout.Value);
                }

                return customer;

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
