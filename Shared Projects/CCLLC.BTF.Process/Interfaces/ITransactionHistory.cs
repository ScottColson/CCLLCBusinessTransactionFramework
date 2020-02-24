using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public interface ITransactionHistory
    {
        void AddToHistory(IProcessExecutionContext executionContext, IWorkSession session, IProcessStep processStep, bool isExecuted);

        void ArchiveHistoryForStep(IProcessExecutionContext executionContext, IWorkSession session, IProcessStep processStep, bool isRolledBack = false);

        /// <summary>
        /// Return the current history record for the specified step if it exists.
        /// </summary>
        /// <param name="processStep"></param>
        /// <returns></returns>
        IStepHistory GetHistoryForStep(IProcessStep processStep);

        IStepHistory GetHistoryById(IRecordPointer<Guid> stepHistoryId);


        /// <summary>
        /// Returns a list of process steps to navigate from the current step of the transaction
        /// to the last accessible UI step prior to the current step.
        /// </summary>
        /// <returns></returns>
        IList<IProcessStep> GetReversingSteps();
    }
}
