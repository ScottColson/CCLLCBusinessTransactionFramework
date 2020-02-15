using System;

namespace CCLLC.BTF.Documents
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public interface IGeneratedDocument : IRecordPointer<Guid>
    {       
        IRecordPointer<Guid> TransactionId { get; }
        ICustomer Customer { get; }
    }
}
