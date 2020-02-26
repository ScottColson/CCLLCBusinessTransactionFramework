using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class AppliedFee : RecordPointer<Guid>, IAppliedFee
    {
       
        public decimal Quantity { get; private set; }

        public decimal UnitPrice { get; private set; }

        public decimal TotalPrice { get; private set; }

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
            var unitPrice = priceCalculator.CalculateUnitPrice(executionContext, this.Fee, this.Quantity);
            if(unitPrice != this.UnitPrice)
            {
                this.UnitPrice = UnitPrice;
                this.TotalPrice = this.Quantity * unitPrice;                
            }

        }

        public void IncrementQuantity(decimal incrementValue = 1)
        {
            if(incrementValue > 0)
            {
                this.Quantity += incrementValue;
                this.TotalPrice = this.Quantity * this.Quantity;
            }

        }

        public void DecrementQuantity(decimal decrementValue = 1)
        {
            if (decrementValue > 0)
            {
                this.Quantity -= decrementValue;
                if (this.Quantity < 0) { this.Quantity = 0; }
                this.TotalPrice = this.Quantity * this.Quantity;
            }
        }
    }
}
