using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCLLC.Core;
using CCLLC.BTF.Revenue;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeAppliedFee : IAppliedFee
    {
        public IRecordPointer<Guid> TransactionId => throw new NotImplementedException();

        public IFee Fee { get; }

        public decimal Quantity { get; }

        public decimal UnitPrice { get; }

        public decimal TotalPrice { get; }

        public string RecordType { get; }

        public Guid Id { get; }

        public string Name { get; }

        public FakeAppliedFee(TestProxy.ccllc_appliedfee record)
        {
            RecordType = record.LogicalName;
            Id = record.Id;

            if(record.ccllc_FeeId != null)
            {
                Fee = new Fee(record.ccllc_FeeId.LogicalName, record.ccllc_FeeId.Id, null);
            }
        }

        public void CalculatePrice(IProcessExecutionContext executionContext, DateTime? pricingDate)
        {
            throw new NotImplementedException();
        }


    }
}
