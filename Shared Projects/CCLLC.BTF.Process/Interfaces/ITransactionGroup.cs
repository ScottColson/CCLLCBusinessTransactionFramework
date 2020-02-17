using System;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Identifies a group used to organize <see cref="ITransactionType"/> records for
    /// display in the user interface.
    /// </summary>
    public interface ITransactionGroup
    {
        Guid Id { get; }
        string Name { get; }
        int DisplayRank { get; }
    }
}
