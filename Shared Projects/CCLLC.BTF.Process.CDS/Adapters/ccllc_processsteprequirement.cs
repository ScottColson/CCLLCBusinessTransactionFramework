using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_processsteprequirement : IStepRequirement
    {
        public bool BlockProcessProgress => throw new NotImplementedException();

        public IRecordPointer<Guid> RequirementId => this.ccllc_TransactionRequirementId != null ? this.ccllc_TransactionRequirementId.ToRecordPointer() : null;
        
    }
}
