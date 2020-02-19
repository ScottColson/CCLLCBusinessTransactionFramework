using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using DLaB.Xrm.Test;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeCustomer : ICustomer
    {
        public eCustomerTypeEnum Type { get; }

        public IReadOnlyList<IRecordClass> RecordClasses => throw new NotImplementedException();

        public string RecordType { get; }

        public Guid Id { get; }

        public string Name { get; private set; }

        public FakeCustomer(Id id)
        {
            RecordType = id.LogicalName;
            Id = id.EntityId;

            if(RecordType == "contact")
            {
                Type = eCustomerTypeEnum.Contact;
            }
            else
            {
                Type = eCustomerTypeEnum.Account;
            }
        }

        public FakeCustomer(IRecordPointer<Guid> pointer)
        {
            RecordType = pointer.RecordType;
            Id = pointer.Id;

            if (RecordType == "contact")
            {
                Type = eCustomerTypeEnum.Contact;
            }
            else
            {
                Type = eCustomerTypeEnum.Account;
            }
        }
    }
}
