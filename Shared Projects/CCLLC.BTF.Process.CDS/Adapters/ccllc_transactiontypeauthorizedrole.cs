using System;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;

    public partial class ccllc_transactiontypeauthorizedrole : IAuthroizedRoleRecord
    {
        public IRecordPointer<Guid> RoleId => this.ccllc_RoleId?.ToRecordPointer();

        public IRecordPointer<Guid> ParentId => this.ccllc_TransactionTypeId?.ToRecordPointer();
    }
}
