using System;

namespace CCLLC.BTF.Revenue.CDS
{
    using CCLLC.Core;

    public partial class ccllc_appliedfee : IAppliedFeeRecord
    {
        public IRecordPointer<Guid> TransactionId => this.ccllc_TransactionId?.ToRecordPointer();

        public IRecordPointer<Guid> FeeId => this.ccllc_FeeId?.ToRecordPointer();

        public decimal Quantity => this.ccllc_Quantity ?? 0m;

        public decimal UnitPrice => this.ccllc_UnitPrice?.Value ?? 0m;

        public decimal TotalPrice => this.ccllc_TotalPrice?.Value ?? 0m;

        public string RecordType => this.LogicalName;       

        public string Name => this.ccllc_name;
        
    }
}
