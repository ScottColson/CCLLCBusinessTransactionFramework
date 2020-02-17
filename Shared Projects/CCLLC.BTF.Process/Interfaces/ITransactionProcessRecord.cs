using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionProcessRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        IRecordPointer<Guid> TransactionTypeId { get; }
        IRecordPointer<Guid> InitialProcessStepId { get; }
    }
}
