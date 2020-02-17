using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IRequirementWaiverRole
    {
        IRecordPointer<Guid> TransactionRequirementId { get; }

        IRecordPointer<Guid> RoleId { get; }
    }
}
