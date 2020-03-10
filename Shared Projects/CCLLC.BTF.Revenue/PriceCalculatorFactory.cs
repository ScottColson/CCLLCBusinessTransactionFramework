using System;
using CCLLC.BTF.Platform;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public class PriceCalculatorFactory : IPriceCalculatorFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.PriceCalculator.{0}.{1}.{2}";

        protected IRevenueSettingsFactory SettingsFactory { get; }

        public PriceCalculatorFactory(IRevenueSettingsFactory settingsFactory)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
        }

        public IPriceCalculator CreatePriceCalculator(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, bool useCache = true)
        {
            useCache = useCache && executionContext.Cache != null;

            TimeSpan? cacheTimeout = null;
            string cacheKey = null;

            if (useCache)
            {
                cacheKey = string.Format(CACHE_KEY, session?.Location?.Id, session?.Channel?.Id, transaction?.PricingDate.ToShortDateString());

                var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                cacheTimeout = settings.PricingCalculatorCacheTimeout;

                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<IPriceCalculator>(cacheKey);
                }
            }

            //TEMPORARY IMPLEMENTATION

            var priceCalculator = new PriceCalculator();

            if(useCache)
            {
                executionContext.Cache.Add<IPriceCalculator>(cacheKey, priceCalculator, cacheTimeout.Value);
            }

            return priceCalculator;
        }
    }
}
