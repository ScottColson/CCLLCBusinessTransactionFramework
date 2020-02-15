using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueDataConnector
    {
        IFee GetFeeRecord(IDataService dataService, IRecordPointer<Guid> feeId);

        IAppliedFeeRecord CreateAppliedTransactionFee(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, string name, decimal quantity, decimal? unitPrice = null, decimal? totalPrice = null);

        IList<IAppliedFeeRecord> GetAppliedTransactionFees(IDataService dataService, IRecordPointer<Guid> transactionId);
    }
}
