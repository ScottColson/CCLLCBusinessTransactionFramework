namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IPriceCalculator
    {
        decimal CalculateUnitPrice(IProcessExecutionContext executionContext, IFee fee, decimal quantity);
    }
}
