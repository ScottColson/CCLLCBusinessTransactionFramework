using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueDataConnector
    {
        IFee GetFeeRecord(IDataService dataService, IRecordPointer<Guid> feeId);

        ITransactionFeeRecord CreateAppliedTransactionFee(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, string name, decimal quantity, decimal? unitPrice = null, decimal? totalPrice = null);

        IList<ITransactionFeeRecord> GetAppliedTransactionFees(IDataService dataService, IRecordPointer<Guid> transactionId);

        void UpdateAppliedTransactionFee(IDataService dataService, ITransactionFeeRecord record);
    }
}
