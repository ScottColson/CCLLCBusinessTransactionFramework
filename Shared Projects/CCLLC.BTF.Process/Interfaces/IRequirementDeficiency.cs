using System;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IRequirementDeficiency : IRequirementDeficiencyRecord
    {
        new IRequirement Requirement { get; }
        new IAgent WaivedBy { get; }        
        
        bool CanWaive(IWorkSession workSession);

        void Waive(IProcessExecutionContext executionContext, IWorkSession workSession);
    }
}
