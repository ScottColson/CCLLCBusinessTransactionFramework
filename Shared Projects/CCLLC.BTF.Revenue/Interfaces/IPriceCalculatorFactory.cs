using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public interface IPriceCalculatorFactory
    {
        IPriceCalculator CreatePriceCalculator(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, TimeSpan? overrideCacheTimeout = null);
    }
}
