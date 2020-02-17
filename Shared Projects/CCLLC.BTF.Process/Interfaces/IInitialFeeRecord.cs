using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IInitialFeeRecord
    {
        IRecordPointer<Guid> FeeId { get; }
        IRecordPointer<Guid> TransactionTypeId { get;  }

    }
}
