using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IAuthroizedChannelRecord
    {
        IRecordPointer<Guid> ParentId { get; }
        IRecordPointer<Guid> ChannelId { get; }
    }
}
