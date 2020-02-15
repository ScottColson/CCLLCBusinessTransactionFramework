using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IDeferredImplementation : IRecordPointer<Guid>
    {       
        string Name { get; }
        string ImplementationAssembly { get; }
        string ImplementationClass { get; }
    }
}
