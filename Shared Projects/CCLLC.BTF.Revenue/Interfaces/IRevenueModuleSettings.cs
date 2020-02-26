using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueModuleSettings : ISettingsProvider
    {
        TimeSpan? PricingCalculatorCacheTimeout { get; }
    }
}
