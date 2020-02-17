using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{ 
    public partial class ccllc_transactioninitialfee
    {
        internal IRecordPointer<Guid> GetFee()
        {
            if (this.ccllc_FeeId == null) throw new ArgumentNullException("ccllc_FeeId is null.");

            return this.ccllc_FeeId.ToRecordPointer();
        }
    }
}
