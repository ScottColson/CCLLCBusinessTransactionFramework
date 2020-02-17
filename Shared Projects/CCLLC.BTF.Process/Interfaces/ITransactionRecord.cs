using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionRecord : IRecordPointer<Guid>
    {
        IRecordPointer<Guid> TransactionTypeId { get; }
        IRecordPointer<Guid> ContextRecordId { get; }
        string Name { get; }
        string ReferenceNumber { get; }

        IRecordPointer<Guid> InitiatingProcessId { get; }
        IRecordPointer<Guid> CurrentProcessId { get; }
        IRecordPointer<Guid> CurrentStepId { get; }
        IRecordPointer<Guid> CustomerId { get; }
        IRecordPointer<Guid> InitiatingAgentId { get; }
        IRecordPointer<Guid> InitiatingLocationId { get; }
    }
}
