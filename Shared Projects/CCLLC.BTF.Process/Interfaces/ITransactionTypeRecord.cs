using System;


namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionTypeRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        int DisplayRank { get; }
        string DataRecordConfiguration { get; }
        IRecordPointer<Guid> TransactionGroupId { get; }
        IRecordPointer<Guid> StartupProcessId { get; }        
    }
}
