using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IAuthroizedRoleRecord
    {
        IRecordPointer<Guid> ParentId { get; }
        IRecordPointer<Guid> RoleId { get; }
    }
}
