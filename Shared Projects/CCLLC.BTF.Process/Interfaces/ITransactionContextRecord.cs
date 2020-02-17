using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionContextRecord : IRecordPointer<Guid>
    {
        int Status { get; }
        string Name { get; }
        IRecordPointer<Guid> CustomerId { get; }
    }
}
