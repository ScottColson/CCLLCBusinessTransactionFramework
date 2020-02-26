using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public interface ITransactionFeeList : IReadOnlyList<ITransactionFee>
    {        
        void AddFee(IProcessExecutionContext executionContext, IWorkSession session, IFee fee, decimal quantity = 1);

        void RemoveFee(IProcessExecutionContext executionContext, IWorkSession session, IFee fee, decimal quantity = 1);
    }
}
