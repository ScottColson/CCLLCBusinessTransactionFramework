using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class RevenueSettings : SettingsProvider, IRevenueSettings
    {
        public TimeSpan? FeeListCacheTimeout => GetValue<TimeSpan?>("BTF.FeeCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? PricingCalculatorCacheTimeout => GetValue<TimeSpan?>("BTF.PricingCalculatorCacheTimeout", TimeSpan.FromMinutes(10));

        public RevenueSettings(ISettingsProvider settingsProvider) : base(settingsProvider)
        {
        }
    }
}
