using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue.CDS
{
    public class RevenueDataConnector : IRevenueDataConnector
    {
        public IAppliedFeeRecord CreateAppliedTransactionFee(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, string name, decimal quantity, decimal? unitPrice = null, decimal? totalPrice = null)
        {            
            var record = new ccllc_appliedfee
            {
                ccllc_TransactionId = transactionId.ToEntityReference(),
                ccllc_FeeId = feeId.ToEntityReference(),
                ccllc_name = name,
            };

            record.Id = dataService.ToOrgService().Create(record);

            return record;
        }

        public IList<IAppliedFeeRecord> GetAppliedTransactionFees(IDataService dataService, IRecordPointer<Guid> transactionId)
        {
            return dataService.ToOrgService().Query<ccllc_appliedfee>()
                .IncludeAllColumns()
                .Where(e => e
                    .Attribute(a => a.Named("ccllc_transactionid").Is(ConditionOperator.Equal).To(transactionId))
                    .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                .RetrieveAll().ToList<IAppliedFeeRecord>();
        }

        public IFee GetFeeRecord(IDataService dataService, IRecordPointer<Guid> feeId)
        {
            return dataService.ToOrgService().Retrieve(
                feeId.RecordType, 
                feeId.Id, new ColumnSet("ccllc_feeid", "ccllc_name"))
                    .ToEntity<ccllc_fee>();           
        }
    }
}
