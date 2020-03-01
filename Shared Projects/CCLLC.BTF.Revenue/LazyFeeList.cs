using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    /// <summary>
    /// Maintains a cached list of Fees that have been pulled from the data store and
    /// returns a cached Fee if it is available. Otherwise retrieves the fee, caches it
    /// and returns it.
    /// </summary>
    public class LazyFeeList : IFeeList
    {
        private const string CACHE_KEY = "CCLLC.BTF.Revenue.FeeList";

        private IRevenueDataConnector DataConnector { get; }
        private IRevenueSettingsFactory SettingsFactory { get; }

        public LazyFeeList(IRevenueSettingsFactory settingsFactory, IRevenueDataConnector dataConnector)
        {
            SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
        }

        public IFee GetFee(IProcessExecutionContext executionContext, IRecordPointer<Guid> feeId, bool useCache = true)
        {
            var feeList = getFeeList(executionContext, useCache);

            var fee = feeList.Where(r => r.Id == feeId.Id).FirstOrDefault();

            if (fee is null)
            {
                fee = DataConnector.GetFeeById(executionContext.DataService, feeId) ?? throw new Exception("Requested Fee does not exist."); ;

                if (useCache)
                {
                    feeList.Add(fee);
                    cacheFeeList(executionContext, feeList);
                }
            }

            return fee;
        }

        public IFee GetFee(IProcessExecutionContext executionContext, string name, bool useCache = true)
        {           
            var feeList = getFeeList(executionContext, useCache);

            var fee = feeList.Where(r => r.Name == name).FirstOrDefault();

            if (fee is null)
            {
                fee = DataConnector.GetFeeByName(executionContext.DataService, name) ?? throw new Exception("Requested Fee does not exist.");

                if (useCache)
                {
                    feeList.Add(fee);
                    cacheFeeList(executionContext, feeList);
                }
            }

            return fee;
        }

        private IList<IFee> getFeeList(IProcessExecutionContext executionContext, bool useCache)
        {
            useCache = useCache && executionContext.Cache != null;

            var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

            if (useCache && executionContext.Cache.Equals(CACHE_KEY))
            {
                return executionContext.Cache.Get<IList<IFee>>(CACHE_KEY);
            }            

            var feeList = new List<IFee>();

            if (useCache)
            {
                executionContext.Cache.Add<IList<IFee>>(CACHE_KEY, feeList, cacheTimeout.Value);
            }

            return feeList;
        }

        private void cacheFeeList(IProcessExecutionContext executionContext, IList<IFee> feeList)
        {
            var useCache = executionContext.Cache != null;

            if (useCache)
            {
                var cacheTimeout = getCacheTimeout(executionContext);
                executionContext.Cache.Add<IList<IFee>>(CACHE_KEY, feeList, cacheTimeout.Value);
            }
        }

        private TimeSpan? getCacheTimeout(IProcessExecutionContext executionContext)
        {
            var settings = SettingsFactory.CreateSettings(executionContext.Settings);            
            return settings.FeeListCacheTimeout;
        }
    }
}
