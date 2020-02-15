using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class AppliedFee : RecordPointer<Guid>, IAppliedFee
    {
        public IRecordPointer<Guid> TransactionId { get; }

        public IFee Fee {get;}

        public decimal Quantity { get; }

        public decimal UnitPrice { get; }

        public decimal TotalPrice { get; }

        internal AppliedFee(IAppliedFeeRecord appliedFeeRecord, IFee fee) :
            base(appliedFeeRecord.RecordType,appliedFeeRecord.Id)
        {
            TransactionId = appliedFeeRecord.TransactionId;
            Quantity = appliedFeeRecord.Quantity;
            UnitPrice = appliedFeeRecord.UnitPrice;
            TotalPrice = appliedFeeRecord.TotalPrice;
            Fee = fee;
        }
       
        public void CalculatePrice(IProcessExecutionContext executionContext, DateTime? pricingDate)
        {
            throw new NotImplementedException();
        }
    }
}
