using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class AppliedFeeManager : IAppliedFeeManager
    {
        private const string CACHE_KEY = "CCLLC.BTF.Revenue.FeeManager";

        protected IRevenueDataConnector DataConnector { get; }

        public AppliedFeeManager(IRevenueDataConnector dataConnector)
        {
            DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
        }

        public void AddAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, decimal? quantity = null)
        {
            try
            {
                if (feeList is null) feeList = new List<IAppliedFee>();
                if (quantity is null) quantity = 1;

                // check to see if the related fee is already applied in the list. If so we will update that item rather than create
                // a new one.
                var existingFee = feeList.Where(r => r.Fee.Id == feeId.Id).FirstOrDefault();

                if(existingFee is null)
                {                    
                    var fee = DataConnector.GetFeeRecord(executionContext.DataService, feeId);

                    var appliedFeeRecord = DataConnector.CreateAppliedTransactionFee(
                        executionContext.DataService,
                        transactionId,
                        fee,
                        fee.Name,
                        quantity.Value);
                  
                    var appliedFee = new AppliedFee(appliedFeeRecord, fee);

                    feeList.Add(appliedFee);
                }
                else
                {
                    throw new NotImplementedException("Modifying an existing applied fee is not implemented yet.");
                }     
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
     
        public IList<IAppliedFee> LoadAppliedFees(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeout = null)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (transactionId is null) throw new ArgumentNullException("transactionId");

                string cacheKey = null;
                if (executionContext.Cache != null && cacheTimeout != null)
                {
                    cacheKey = CACHE_KEY + ".fees." + transactionId.ToString();                    
                }

                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<IList<IAppliedFee>>(cacheKey);
                }

                IList<IAppliedFee> appliedFees = new List<IAppliedFee>();
               
                var appliedFeeRecords = DataConnector.GetAppliedTransactionFees(executionContext.DataService, transactionId);

                foreach(var r in appliedFeeRecords)
                {
                    var fee = r.FeeId != null ? DataConnector.GetFeeRecord(executionContext.DataService, r.FeeId) : null;
                    appliedFees.Add(new AppliedFee(r,fee));
                }

                if (cacheKey != null)
                {
                    executionContext.Cache.Add(cacheKey, appliedFees, cacheTimeout.Value);
                }

                return appliedFees;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
             

        public void RemoveAppliedFee(IProcessExecutionContext executionContext, IList<IAppliedFee> feeList, IRecordPointer<Guid> feeId, decimal? quantity = null)
        {
            throw new NotImplementedException();
        }
    }
}
