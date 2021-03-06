﻿using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueDataConnector
    {
        IFee GetFeeById(IDataService dataService, IRecordPointer<Guid> feeId);

        IFee GetFeeByName(IDataService dataService, string name);

        ITransactionFeeRecord CreateTransactionFee(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> feeId, string name, decimal quantity, decimal? unitPrice = null, decimal? totalPrice = null);

        IList<ITransactionFeeRecord> GetTransactionFees(IDataService dataService, IRecordPointer<Guid> transactionId);

        void UpdateTransactionFee(IDataService dataService, ITransactionFeeRecord record);
    }
}
