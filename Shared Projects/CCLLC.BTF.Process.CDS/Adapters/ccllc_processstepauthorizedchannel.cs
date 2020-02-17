using System;
using CCLLC.Core;


namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_processstepauthorizedchannel : IAuthroizedChannelRecord
    {
        public IRecordPointer<Guid> ParentId => this.ccllc_ProcessStepId?.ToRecordPointer();

        public IRecordPointer<Guid> ChannelId => this.ccllc_ChannelId?.ToRecordPointer();
    }
}
