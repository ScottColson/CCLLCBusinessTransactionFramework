using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class ccllc_channel : IChannelRecord
    {
        public string Name => this.ccllc_name;

        public eChannelTypeEnum Type => this.ccllc_ChannelTypeCode.HasValue ? (eChannelTypeEnum)this.ccllc_ChannelTypeCode.Value : eChannelTypeEnum.InternalDirect;

        public eChannelCustomerScopeEnum CustomerScope => this.ccllc_CustomerInteractionScopeCode.HasValue ? (eChannelCustomerScopeEnum)this.ccllc_CustomerInteractionScopeCode.Value : eChannelCustomerScopeEnum.AuthorizedCustomers;
       
        public string RecordType => this.LogicalName;

        public IRecordPointer<Guid> PartnerId => this.ccllc_PartnerId.ToRecordPointer();
    }
}
