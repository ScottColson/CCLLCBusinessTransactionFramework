using System;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public class Fee : RecordPointer<Guid>, IFee
    {
        public string Name { get; }
        public string ReferenceNumber { get; }
        public Fee(string recordType, Guid Id, string name, string referenceNumber) : base(recordType,Id)
        {
            Name = name;
            ReferenceNumber = referenceNumber;
        }

        
    }
}
