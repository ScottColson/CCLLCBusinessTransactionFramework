using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_RequirementWaiverRole : IRequirementWaiverRole
    {
        public IRecordPointer<Guid> TransactionRequirementId => this.ccllc_RequirementId?.ToRecordPointer();

        public IRecordPointer<Guid> RoleId => this.ccllc_RoleId?.ToRecordPointer();
    }
}
