using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface ITransactionFeeListFactory
    {       
        ITransactionFeeList CreateFeeList(IProcessExecutionContext executionContext, ITransaction transaction);
    }
}
