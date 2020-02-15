using System;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public interface IAppliedFee : IRecordPointer<Guid>
    {
        IRecordPointer<Guid> TransactionId { get; }
        IFee Fee { get; }
        decimal Quantity { get; }
        decimal UnitPrice { get; }
        decimal TotalPrice { get; }

        void CalculatePrice(IProcessExecutionContext executionContext, DateTime? pricingDate);
    }
}
