using System;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public class RequirementDeficiency : RecordPointer<Guid>, IRequirementDeficiency
    {
        public IRequirement Requirement { get; }

        public IAgent WaivedBy { get; }

        public DateTime? WaivedOn { get; }

        public eDeficiencyStatusEnum Status { get; }

        IRecordPointer<Guid> IRequirementDeficiencyRecord.WaivedBy => this.WaivedBy;

        IRecordPointer<Guid> IRequirementDeficiencyRecord.Requirement => this.Requirement;

        public RequirementDeficiency(IRequirement requirement, eDeficiencyStatusEnum status, IAgent waivedBy, DateTime? waivedOn)
        {
            Requirement = requirement ?? throw new ArgumentNullException("requirement");
            Status = status;
            WaivedBy = waivedBy;
            WaivedOn = waivedOn;
        }

        public bool CanWaive(IWorkSession workSession)
        {
           if(Requirement.AuthorizedWaiverRoles.Count > 0)
            {
                return workSession.HasRole(Requirement.AuthorizedWaiverRoles);
            }

            return false;
        }

        public void Waive(IProcessExecutionContext executionContext, IWorkSession workSession)
        {
            throw new NotImplementedException();
        }
    }
}
