using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ITransaction : IRecordPointer<Guid>
    {   
        string Name { get; }
        ICustomer Customer { get; }
        string ReferenceNumber { get; }
    }
}
