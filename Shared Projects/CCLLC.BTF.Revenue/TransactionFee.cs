using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class TransactionFee : RecordPointer<Guid>, ITransactionFee
    {
       
        public decimal Quantity { get; private set; }

        public decimal UnitPrice { get; private set; }

        public decimal TotalPrice { get; private set; }

        public IFee Fee { get; }

        public IRecordPointer<Guid> TransactionId { get; }

        IRecordPointer<Guid> ITransactionFeeRecord.Fee => this.Fee as IRecordPointer<Guid>;              

        internal TransactionFee(ITransactionFeeRecord transactionFeeRecord, IFee fee) :
            base(transactionFeeRecord.RecordType, transactionFeeRecord.Id)
        {            
            TransactionId = transactionFeeRecord.TransactionId;
            Quantity = transactionFeeRecord.Quantity;
            UnitPrice = transactionFeeRecord.UnitPrice;
            TotalPrice = transactionFeeRecord.TotalPrice;
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
