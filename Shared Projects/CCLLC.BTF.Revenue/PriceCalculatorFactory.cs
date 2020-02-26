using System;
using System.Collections.Generic;
using System.Text;
using CCLLC.BTF.Platform;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public class PriceCalculatorFactory : IPriceCalculatorFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.PriceCalculator.{0}.{1}.{2}";
        public IPriceCalculator CreatePriceCalculator(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, TimeSpan? overrideCacheTimeout = null)
        {
            var settings = new RevenueModuleSettings(executionContext.Settings);

            var cacheTimeout = overrideCacheTimeout ?? settings.PricingCalculatorCacheTimeout;

            string cacheKey = null;
            if(executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = string.Format(CACHE_KEY, session.Location.Id, session.Channel.Id, transaction.PricingDate.ToShortDateString());
            }

            if(executionContext.Cache.Exists(cacheKey))
            {
                return executionContext.Cache.Get<IPriceCalculator>(cacheKey);
            }

            //TEMPORARY IMPLEMENTATION

            var priceCalculator = new PriceCalculator();

            if(cacheKey != null)
            {
                executionContext.Cache.Add<IPriceCalculator>(cacheKey, priceCalculator, cacheTimeout.Value);
            }

            return priceCalculator;
        }
    }
}
