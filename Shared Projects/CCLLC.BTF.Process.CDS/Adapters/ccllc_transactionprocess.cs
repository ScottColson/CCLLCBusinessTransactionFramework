using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactionprocess : ITransactionProcessRecord
    {
        public string Name => this.ccllc_name;

        public IRecordPointer<Guid> TransactionTypeId => this.ccllc_TransactionTypeId?.ToRecordPointer();
        public IRecordPointer<Guid> InitialProcessStepId => this.ccllc_InitialProcessStepId?.ToRecordPointer();

        public string RecordType => this.LogicalName;
    }
}
