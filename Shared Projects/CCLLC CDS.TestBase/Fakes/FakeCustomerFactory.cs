using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;


namespace CCLLC.CDS.Test.Fakes
{
    public class FakeCustomerFactory : ICustomerFactory
    {       
        public ICustomer CreateCustomer(IProcessExecutionContext executionContext, IRecordPointer<Guid> customerId, TimeSpan? cacheTimeout = null)
        {
            return new FakeCustomer(customerId);
        }
    }
}
