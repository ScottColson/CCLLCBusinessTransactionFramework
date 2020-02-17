
using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{

    public partial class ccllc_transactiontype : ITransactionTypeRecord
    {
        public string Name => this.ccllc_name;

        public int DisplayRank => this.ccllc_DisplayRank ?? -1;

        public string DataRecordConfiguration => this.ccllc_DataRecordConfiguration;

        public string RecordType => this.LogicalName;

        public IRecordPointer<Guid> TransactionGroupId => this.ccllc_TransactionGroupId?.ToRecordPointer();

        public IRecordPointer<Guid> StartupProcessId => this.ccllc_StartupProcessId?.ToRecordPointer();
    }
}
