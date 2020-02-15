using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;
    public class Channel : RecordPointer<Guid>, IChannel
    {
        public string Name { get; }

        public eChannelTypeEnum Type { get; }

        public eChannelCustomerScopeEnum CustomerScope { get; }

        public IPartner Partner { get; }

        internal Channel(IChannelRecord channelRecord, IPartner partner)
            : base(channelRecord.RecordType,channelRecord.Id)
        {
            Name = channelRecord.Name;
            Type = channelRecord.Type;
            CustomerScope = channelRecord.CustomerScope;
            Partner = partner;
        }
    }
}
