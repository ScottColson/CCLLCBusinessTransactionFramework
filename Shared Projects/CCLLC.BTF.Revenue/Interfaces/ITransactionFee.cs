namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface ITransactionFee : ITransactionFeeRecord
    {      
        new IFee Fee { get; }
               
        void CalculatePrice(IProcessExecutionContext executionContext, IPriceCalculator priceCalculator);

        void IncrementQuantity(decimal incrementValue = 1);

        void DecrementQuantity(decimal decrementValue = 1);
    }
}
