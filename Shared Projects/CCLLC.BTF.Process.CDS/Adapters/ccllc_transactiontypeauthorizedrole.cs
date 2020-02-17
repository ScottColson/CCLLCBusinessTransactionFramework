using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactiontypeauthorizedrole
    {
        internal IRecordPointer<Guid> GetRole()
        {
            if (this.ccllc_RoleId == null) throw new ArgumentNullException("ccllc_RoleId is null.");

            return this.ccllc_RoleId.ToRecordPointer();
        }
    }
}
