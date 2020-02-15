using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IWorkSession
    {
        IAgent Agent { get; }
        IChannel Channel { get; }
        ILocation Location { get; }
        IDevice Workstation { get; }
        IDevice Scanner { get; }
        IDevice Output { get; }
        IDevice Camera { get; }

        bool SupportsChannel(IRecordPointer<Guid> channel);
        bool SupportsChannel(IEnumerable<IRecordPointer<Guid>> channels);
        bool HasRole(IRecordPointer<Guid> role);
        bool HasRole(IEnumerable<IRecordPointer<Guid>> roles);

        bool CanOperateAgainstCustomer(ICustomer customer);
    }
}
