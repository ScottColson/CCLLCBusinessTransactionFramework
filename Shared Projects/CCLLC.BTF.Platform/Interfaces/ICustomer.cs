using System.Collections.Generic;

namespace CCLLC.BTF.Platform
{
    public interface ICustomer : ICustomerRecord
    {      
        IReadOnlyList<IRecordClass> RecordClasses { get; }
    }
}
