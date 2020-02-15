using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IChannelRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        eChannelTypeEnum Type { get; }
        eChannelCustomerScopeEnum CustomerScope { get; }
        IRecordPointer<Guid> PartnerId { get; }
    }
}
