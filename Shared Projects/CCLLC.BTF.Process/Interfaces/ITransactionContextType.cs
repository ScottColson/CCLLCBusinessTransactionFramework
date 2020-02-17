using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionContextType 
    {
        string RecordType { get; }
        IRecordPointer<Guid> TransactionTypeId { get; }
    }
}
