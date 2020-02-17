using System;

namespace CCLLC.BTF.Process.CDS
{ 
    public partial class ccllc_transactiontypecontext : IContextType
    {
        public string RecordType => this.ccllc_name;

        public int RecordStatus => throw new NotFiniteNumberException();
       
    }
}
