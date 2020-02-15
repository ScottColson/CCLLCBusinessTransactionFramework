using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface ICustomerRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        eCustomerTypeEnum Type { get; }
    }
}
