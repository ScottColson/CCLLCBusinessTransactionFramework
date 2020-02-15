using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ICustomerManager
    {
        ICustomer GetCustomerById(IProcessExecutionContext exexcutionContext, eCustomerTypeEnum customerType, Guid Id);
    }
}
