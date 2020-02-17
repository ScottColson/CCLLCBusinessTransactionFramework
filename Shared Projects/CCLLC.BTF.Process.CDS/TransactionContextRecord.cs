using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public class TransactionContextRecord : RecordPointer<Guid>, ITransactionContextRecord
    {
        public int Status { get; }

        public string Name { get; }

        public IRecordPointer<Guid> CustomerId { get; }

        public TransactionContextRecord(string recordType, Guid id, string name, IRecordPointer<Guid> customerId, int status)
            : base(recordType,id)
        {
            Name = name;
            CustomerId = customerId;
            Status = status;
        }       
    }
}
