﻿using System;
using CCLLC.Core;
using CCLLC.BTF.Revenue;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeTransactionFee : ITransactionFee
    {
        public IRecordPointer<Guid> TransactionId => throw new NotImplementedException();

        public IFee Fee { get; }

        public decimal Quantity { get; }

        public decimal UnitPrice { get; }

        public decimal TotalPrice { get; }

        public string RecordType { get; }

        public Guid Id { get; }

        public string Name { get; }

        IRecordPointer<Guid> ITransactionFeeRecord.Fee => throw new NotImplementedException();

        public FakeTransactionFee(TestProxy.ccllc_transactionfee record)
        {
            RecordType = record.LogicalName;
            Id = record.Id;

            if(record.ccllc_FeeId != null)
            {
                Fee = new Fee(record.ccllc_FeeId.LogicalName, record.ccllc_FeeId.Id, record.ccllc_name, null);
            }
        }

        public void CalculatePrice(IProcessExecutionContext executionContext, IPriceCalculator priceCalculator)
        {
            throw new NotImplementedException();
        }

        public void IncrementQuantity(decimal incrementValue = 1)
        {
            throw new NotImplementedException();
        }

        public void DecrementQuantity(decimal decrementValue = 1)
        {
            throw new NotImplementedException();
        }
    }
}
