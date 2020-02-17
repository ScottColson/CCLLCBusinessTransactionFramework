using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactionrequirementwaiverrole : IRequirementWaiverRole
    {
        public IRecordPointer<Guid> TransactionRequirementId => this.ccllc_TransactionRequirementId?.ToRecordPointer();

        public IRecordPointer<Guid> RoleId => this.ccllc_RoleId?.ToRecordPointer();
    }
}
