using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Defines properties for any record that is being used to capture data input related to 
    /// a transaction.
    /// </summary>
    public interface ITransactionDataRecord : IRecordPointer<Guid>
    {
        IRecordPointer<Guid> TransactionId { get; }
        IRecordPointer<Guid> CustomerId { get; }
    }
}
