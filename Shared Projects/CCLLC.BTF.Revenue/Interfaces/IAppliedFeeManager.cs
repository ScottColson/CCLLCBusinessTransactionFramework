using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public interface IAppliedFeeManager
    {      
        /// <summary>
        /// Returns a list of <see cref="IAppliedFee"/> items from the data store that are associated with specified transaction id. Caches
        /// results when cacheTimeOut paramater is supplied."/>
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="cacheTimeout"></param>
        /// <returns></returns>
        IList<IAppliedFee> LoadAppliedFees(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeout = null);

        /// <summary>
        /// Creates a new <see cref="IAppliedFee"/> item or updates the quantity of an existing fee and saves it to the 
        /// data store and adds it to the provided list of transaction fees. 
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name-"feeList"></param>
        /// <param name="transactionId"></param>
        /// <param name="feeId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        void AddAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, decimal? quantity = null);

        /// <summary>
        /// Finds the existing fee in the supplied fee list and decrements the quantity or removes it when resulting quantity
        /// is 0. Updates the datastore to persist the change.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="feeList"></param>
        /// <param name="feeId"></param>
        /// <param name="quantity"></param>
        void RemoveAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> feeId, decimal? quantity = null);
    }
}
