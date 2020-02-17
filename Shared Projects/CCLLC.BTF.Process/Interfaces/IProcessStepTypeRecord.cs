using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IProcessStepTypeRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        string ClassName { get; }
        string AssemblyName { get; }
        bool? SupportsConditionalBranching { get; }
    }
}
