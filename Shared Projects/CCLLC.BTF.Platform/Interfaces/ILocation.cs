using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface ILocation : IRecordPointer<Guid>
    {
        string Name { get; }
    }
}
