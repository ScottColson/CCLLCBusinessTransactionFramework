using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Identifies a <see cref="ITransactionRequirement"/> associated with a
    /// <see cref="IProcessStep"/> and defines if failure to validate the 
    /// requriement blocks forward progress on the transaction.
    /// </summary>
    public interface IStepRequirement
    {
        bool BlockProcessProgress { get; }
        IRecordPointer<Guid> RequirementId { get; }
        IRecordPointer<Guid> ProcessStepId { get; }
    }
}
