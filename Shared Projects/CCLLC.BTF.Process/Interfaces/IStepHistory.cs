using System;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    /// <summary>
    /// Tracks history of a <see cref="IProcessStep"/> for the associated 
    /// <see cref="ITransaction"/> record. <see cref="IStepHistory"/> records
    /// contain pointers to the previous and next step which creates a double-linked
    /// list that supports forward and backward navigation through the related
    /// <see cref="ITransactionProcess"/>. Also caputures information for historical
    /// audit purposes.
    /// </summary>
    public interface IStepHistory : IRecordPointer<Guid>
    {
       
        /// <summary>
        /// The id of the <see cref="IProcessStep"/> that is being tracked in history.
        /// </summary>
        IRecordPointer<Guid> ProcessStepId { get; }

        int ExecutionOrder { get; }

        eProcessStepHistoryStatusEnum StepStatus { get; }

        /// <summary>
        /// The id of the associated <see cref="ITransaction"/> item.
        /// </summary>
        IRecordPointer<Guid> TransactionId { get; }

        /// <summary>
        /// The id of the <see cref="IStepHistory"/> completed prior to this step. When null the current history step is the first step.
        /// </summary>
        IRecordPointer<Guid> PreviousStepId { get; }

        /// <summary>
        /// The id of the <see cref="IStepHistory"/> completed after this step. When null, no additional steps have been completed.
        /// </summary>
        IRecordPointer<Guid> NextStepId { get; set; }

        IRecordPointer<Guid> CompletedById { get; }

        DateTime? CompletedOn { get; }

        IRecordPointer<Guid> CompletedAtId { get; }
    }
}
