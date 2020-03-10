using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IRequirementDeficiencyRecord : IRecordPointer<Guid>
    {
        IRecordPointer<Guid> Requirement { get; }
        IRecordPointer<Guid> WaivedBy { get; }
        DateTime? WaivedOn { get; }
        eDeficiencyStatusEnum Status { get; }
    }
}
