using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;


namespace CCLLC.BTF.Process
{
    public interface IStepHistoryManager
    {
        /// <summary>
        /// Returns a list of all existing <see cref="IStepHistory"/> items associated with the <see cref="ITransaction"/>
        /// identified by the supplied id. 
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="cacheTimeout"></param>
        /// <returns></returns>
        IList<IStepHistory> LoadStepHistory(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeout = null);

        /// <summary>
        /// Returns a new <see cref="IStepHistory"/> item after creating and persisting it to the data store.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="transactionId"></param>
        /// <param name="processStepId"></param>
        /// <param name="previousStepHistoryId"></param>
        /// <returns></returns>
        IStepHistory NewStepHistory(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> processStepId, IRecordPointer<Guid> previousStepHistoryId);
               
        void GenerateStepHistory(IProcessExecutionContext executionContext, IList<IStepHistory> historyList, IRecordPointer<Guid> transactionId, IWorkSession workSession, IProcessStep startingStep, IProcessStep currentStep, bool startingStepExecuted = true);

        void ArchiveStepHistory(IProcessExecutionContext executionContext, IList<IStepHistory> historyList, IRecordPointer<Guid> historyId, bool stepRolledBack = false);

    }
}
