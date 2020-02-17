using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{ 
    public partial class ccllc_transactiontypeauthorizedchannel
    {
        internal IRecordPointer<Guid> GetChannel()
        {
            if (this.ccllc_ChannelId == null) throw new ArgumentNullException("ccllc_ChannelId is null.");

            return this.ccllc_ChannelId.ToRecordPointer();
        }
    }
}
