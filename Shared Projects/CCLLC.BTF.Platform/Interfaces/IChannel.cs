using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IChannel : IRecordPointer<Guid>
    {
        string Name { get; }
        eChannelTypeEnum Type { get; }
        eChannelCustomerScopeEnum CustomerScope { get; }       
        IPartner Partner { get; }
    }
}
