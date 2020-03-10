using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueSettings : ISettingsProvider
    {
        TimeSpan? FeeListCacheTimeout { get; }
        TimeSpan? PricingCalculatorCacheTimeout { get; }      
    }
}
