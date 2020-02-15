using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ICustomerFactory
    {
        ICustomer CreateCustomer(IProcessExecutionContext executionContext, IRecordPointer<Guid> customerId, TimeSpan? cacheTimeout = null);
    }
}
