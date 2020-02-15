using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IAgent : IAgentRecord
    {            
        IReadOnlyList<IRole> Roles { get; }
        IReadOnlyList<IRecordPointer<Guid>> AuthorizedCustomers { get; }
        IReadOnlyList<IRecordPointer<Guid>> ProhibitedCustomers { get; }
    }
}
