using System;
using CCLLC.Core;

namespace CCLLC.BTF.Revenue
{
    public interface IFee : IRecordPointer<Guid>
    {
        string Name { get; }
    }
}
