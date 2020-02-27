using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue.CDS
{
    public class RevenueDataConnector : IRevenueDataConnector
    {
        public ITransactionFeeRecord CreateTransactionFee(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, string name, decimal quantity, decimal? unitPrice = null, decimal? totalPrice = null)
        {            
            var record = new ccllc_transactionfee
            {
                ccllc_TransactionId = transactionId.ToEntityReference(),
                ccllc_FeeId = feeId.ToEntityReference(),
                ccllc_name = name,
            };

            record.Id = dataService.ToOrgService().Create(record);

            return record;
        }

        public IList<ITransactionFeeRecord> GetTransactionFees(IDataService dataService, IRecordPointer<Guid> transactionId)
        {
            return dataService.ToOrgService().Query<ccllc_transactionfee>()
                .IncludeAllColumns()
                .Where(e => e
                    .Attribute(a => a.Named("ccllc_transactionid").Is(ConditionOperator.Equal).To(transactionId))
                    .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                .RetrieveAll().ToList<ITransactionFeeRecord>();
        }

        public IFee GetFeeById(IDataService dataService, IRecordPointer<Guid> feeId)
        {
            return dataService.ToOrgService().Retrieve(
                feeId.RecordType, 
                feeId.Id, new ColumnSet("ccllc_feeid", "ccllc_name"))
                    .ToEntity<ccllc_fee>();           
        }

        public IFee GetFeeByName(IDataService dataService, string name)
        {
            var record = dataService.ToOrgService().Query<ccllc_fee>()
                .IncludeAllColumns()
                .Where(e => e
                    .Attribute(a => a.Named("ccllc_name").Is(ConditionOperator.Equal).To(name))
                    .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                .Retrieve().FirstOrDefault();

            if (record is null) throw new Exception(string.Format("Fee '{0}' does not exist.", name));

            return record;
        }

        public void UpdateTransactionFee(IDataService dataService, ITransactionFeeRecord record)
        {
            var updateRecord = new ccllc_transactionfee()
            {
                Id = record.Id,
                ccllc_Quantity = record.Quantity,
                ccllc_UnitPrice = new Microsoft.Xrm.Sdk.Money(record.UnitPrice),
                ccllc_TotalPrice = new Microsoft.Xrm.Sdk.Money(record.TotalPrice)
            };

            dataService.ToOrgService().Update(updateRecord);
        }
    }
}
