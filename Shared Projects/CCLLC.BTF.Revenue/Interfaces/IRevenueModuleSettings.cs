using System;

namespace CCLLC.BTF.Revenue.Interfaces
{
    using CCLLC.Core;

    public interface IRevenueModuleSettings : ISettingsProvider
    {
        TimeSpan? IPricingCalculatorCacheTimeout { get; }
    }
}
