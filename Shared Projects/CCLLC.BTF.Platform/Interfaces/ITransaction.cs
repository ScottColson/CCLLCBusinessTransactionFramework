using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ITransaction : IRecordPointer<Guid>
    {   
        string Name { get; }
        string ReferenceNumber { get; }
        ICustomer Customer { get; } 
        IAgent InitiatingAgent { get; }
        ILocation InitiatingLocation { get; }
    }
}
