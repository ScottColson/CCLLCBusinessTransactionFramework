using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactioninitialfee : IInitialFeeRecord
    {
        public IRecordPointer<Guid> FeeId => this.ccllc_FeeId?.ToRecordPointer();

        public IRecordPointer<Guid> TransactionTypeId => this.ccllc_TransactionTypeId?.ToRecordPointer();       
    }
}
