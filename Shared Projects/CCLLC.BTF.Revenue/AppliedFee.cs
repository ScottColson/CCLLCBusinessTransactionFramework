using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class AppliedFee : RecordPointer<Guid>, IAppliedFee
    {
        public decimal Quantity { get; }

        public decimal UnitPrice { get; }

        public decimal TotalPrice { get; }

        public IFee Fee { get; }

        public IRecordPointer<Guid> TransactionId { get; }

        IRecordPointer<Guid> IAppliedFeeRecord.Fee => this.Fee as IRecordPointer<Guid>;              

        internal AppliedFee(IAppliedFeeRecord appliedFeeRecord, IFee fee) :
            base(appliedFeeRecord.RecordType,appliedFeeRecord.Id)
        {
            TransactionId = appliedFeeRecord.TransactionId;
            Quantity = appliedFeeRecord.Quantity;
            UnitPrice = appliedFeeRecord.UnitPrice;
            TotalPrice = appliedFeeRecord.TotalPrice;
            Fee = fee;
        }

        public void CalculatePrice(IProcessExecutionContext executionContext, IPriceCalculator priceCalculator)
        {
            throw new NotImplementedException();
        }

        public void IncrementQuantity(decimal incrementValue = 1)
        {
            throw new NotImplementedException();
        }

        public void DecrementQuantity(decimal decrementValue = 1)
        {
            throw new NotImplementedException();
        }
    }
}
