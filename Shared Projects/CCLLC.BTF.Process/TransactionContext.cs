using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public class TransactionContext : RecordPointer<Guid>, ITransactionContext
    {
        public int RecordStatus { get; }

        public ICustomer Customer { get; }
        
        public string Name { get; }

        public TransactionContext(string recordType, Guid id, string name, int status, ICustomer customer)
            : base(recordType, id)
        {            
            this.RecordStatus = status;
            this.Name = name;
            this.Customer = customer;
        }

        public TransactionContext(ITransactionContextRecord record, ICustomer customer)
            : base(record.RecordType, record.Id)
        {
            this.RecordStatus = record.Status;
            this.Name = record.Name;
            this.Customer = customer;
        }

        public bool IsContextType(ITransactionContextType contextType)
        {
            return (contextType != null && string.Compare(contextType.RecordType, this.RecordType, true) == 0);            
        }

        public bool IsContextType(IEnumerable<ITransactionContextType> contextTypes)
        {
            foreach(var t in contextTypes)
            {
                if (IsContextType(t))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
