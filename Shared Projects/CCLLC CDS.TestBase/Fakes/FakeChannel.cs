using System;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeChannel : IChannel
    {

        public FakeChannel()
        {
        }

        public FakeChannel(TestProxy.ccllc_channel record)
        {
            RecordType = record.LogicalName;
            Id = record.Id;
            Type = record.ccllc_ChannelTypeCode.HasValue ? (eChannelTypeEnum)record.ccllc_ChannelTypeCode.Value : eChannelTypeEnum.InternalDirect;
            CustomerScope = record.ccllc_CustomerInteractionScopeCode.HasValue ? (eChannelCustomerScopeEnum)record.ccllc_CustomerInteractionScopeCode.Value : eChannelCustomerScopeEnum.AuthorizedCustomers;
            Partner = null;
            Name = record.ccllc_name;
        }

        public eChannelTypeEnum Type { get; set; }

        public eChannelCustomerScopeEnum CustomerScope { get; set; }

        public IPartner Partner { get; set; }

        public string RecordType { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
