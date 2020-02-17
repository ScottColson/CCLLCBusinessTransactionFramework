using System;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IRequirementDeficiency : IRecordPointer<Guid>
    {
        ITransactionRequirement Requirement { get; }
        IStepHistory ValidationStep { get; }
        IAgent WaivedBy { get; }
        DateTime? WaivedOn { get; }
        eDeficiencyStatusEnum Status { get; }

        bool CanWaive(IAgent agent);

        void Waive(IAgent agent);
    }
}
