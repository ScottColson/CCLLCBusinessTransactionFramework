using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public interface ITransactionFeeList : IReadOnlyList<IAppliedFee>
    {        
        void AddFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1);

        void RemoveFee(IProcessExecutionContext executionContext, IWorkSession session, IRecordPointer<Guid> feeId, decimal quantity = 1);
    }
}
