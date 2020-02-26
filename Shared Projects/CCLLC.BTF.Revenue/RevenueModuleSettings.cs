using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core; 

    public class RevenueModuleSettings : ISettingsProvider
    {        
        private ISettingsProvider Settings { get; }

        public TimeSpan? PricingCalculatorCacheTimeout
        {
            get
            {
                var timeoutInSeconds = Settings.Get<int?>("BTF.Revenue.PriceCalculatorCacheTimeout", null);

                if (timeoutInSeconds != null && timeoutInSeconds.Value == 0) { return null; } //Caching disabled.
                
                if (timeoutInSeconds != null && timeoutInSeconds.Value > 0) { return TimeSpan.FromSeconds(timeoutInSeconds.Value); } //Timeout from settings in seconds
                               
                return new TimeSpan(0, 30, 0); //Default to 30 minutes.
            }
        }

        public TimeSpan? FeeListCacheTimeout
        {
            get
            {
                var timeoutInSeconds = Settings.Get<int?>("BTF.Revenue.FeeListCacheTimeout", null);

                if (timeoutInSeconds != null && timeoutInSeconds.Value == 0) { return null; } //Caching disabled.

                if (timeoutInSeconds != null && timeoutInSeconds.Value > 0) { return TimeSpan.FromSeconds(timeoutInSeconds.Value); } //Timeout from settings in seconds

                return new TimeSpan(0, 30, 0); //Default to 30 minutes.
            }
        }

        public RevenueModuleSettings(ISettingsProvider settings)
        {
            Settings = settings ?? throw new ArgumentNullException("settings");
        }

        public T Get<T>(string key, T defaultValue = default(T))
        {
            return Settings.Get<T>(key, defaultValue);
        }
    }
}
