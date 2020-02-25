namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IAppliedFee : IAppliedFeeRecord
    {      
        new IFee Fee { get; }
               
        void CalculatePrice(IProcessExecutionContext executionContext, IPriceCalculator priceCalculator);

        void IncrementQuantity(decimal incrementValue = 1);

        void DecrementQuantity(decimal decrementValue = 1);
    }
}
