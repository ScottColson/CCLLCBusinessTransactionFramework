using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IAgentRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        eAgentTypeEnum Type { get; }
    }
}
