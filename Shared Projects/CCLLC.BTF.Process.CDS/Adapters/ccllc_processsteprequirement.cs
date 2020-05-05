using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_processsteprequirement : IStepRequirement
    {
        public bool BlockProcessProgress => throw new NotImplementedException();

        public IRecordPointer<Guid> RequirementId => this.ccllc_RequirementId?.ToRecordPointer();

        public IRecordPointer<Guid> ProcessStepId => this.ccllc_ProcessStepId?.ToRecordPointer();
    }
}
