using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{ 
    public partial class ccllc_transactiontypecontext : ITransactionContextType
    {
        public string RecordType => this.ccllc_name;        

        public IRecordPointer<Guid> TransactionTypeId => this.ccllc_TransactionTypeId?.ToRecordPointer();
    }
}
