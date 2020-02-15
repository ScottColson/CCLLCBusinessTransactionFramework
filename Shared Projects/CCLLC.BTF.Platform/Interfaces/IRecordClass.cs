using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IRecordClass : IRecordPointer<Guid>
    {
        string name { get; }
    }
}
