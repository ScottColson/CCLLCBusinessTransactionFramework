using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public class Customer : RecordPointer<Guid>, ICustomer
    {

        private List<IRecordClass> recordClasses = null;
        public IReadOnlyList<IRecordClass> RecordClasses => recordClasses;

        public string Name { get; }

        public eCustomerTypeEnum Type { get; }

        protected internal Customer(ICustomerRecord customerRecord, IList<IRecordClass> recordClasses)
            : base(customerRecord.RecordType,customerRecord.Id)
        {
            this.recordClasses = new List<IRecordClass>(recordClasses);
            this.Name = customerRecord.Name;
            this.Type = customerRecord.Type;
        }       
    }
}
