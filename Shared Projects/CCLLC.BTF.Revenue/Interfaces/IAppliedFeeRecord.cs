using System;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public interface IAppliedFeeRecord : IRecordPointer<Guid>
    {
        IRecordPointer<Guid> TransactionId { get; }
        IRecordPointer<Guid> FeeId { get; }
        decimal Quantity { get; }
        decimal UnitPrice { get; }
        decimal TotalPrice { get; }        
    }
}
