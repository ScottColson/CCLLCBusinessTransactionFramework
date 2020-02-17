using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    /// <summary>
    /// Identifies a group used to organize <see cref="ITransactionType"/> records for
    /// display in the user interface.
    /// </summary>
    public interface ITransactionGroup : IRecordPointer<Guid>
    {
        string Name { get; }
        int DisplayRank { get; }
    }
}
