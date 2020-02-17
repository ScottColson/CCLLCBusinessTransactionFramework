using System;
using System.Collections.Generic;
using System.Linq;


namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;

    public class StepHistoryManager : IStepHistoryManager
    {

        private const string CACHE_KEY = "CCLLC.BTF.StepHistoryManager";

        protected IStepHistoryDataConnector DataConnector { get; }

        public StepHistoryManager(IStepHistoryDataConnector dataConnector)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
        }

        public void GenerateStepHistory(IProcessExecutionContext executionContext, IList<IStepHistory> historyList, IRecordPointer<Guid> transactionId, IWorkSession workSession, IProcessStep startingStep, IProcessStep currentStep, bool startingStepExecuted = true)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (historyList is null) throw new ArgumentNullException("historyList");
            if (workSession is null) throw new ArgumentNullException("workSession");            
            if (currentStep is null) throw new ArgumentNullException("currentStep");

            // Find the history corresponding to the starting and ending process steps. 
            var startingHistory = startingStep is null ? null : historyList.Where(r => r.ProcessStepId.Id == startingStep.Id).FirstOrDefault();
            var currentHistory =  historyList.Where(r => r.ProcessStepId.Id == currentStep.Id).FirstOrDefault();

           
            // Create a new history record for the current step if needed and link it back to the starting history. 
            if (currentHistory is null)
            {
                // Save the step history record to the data store and add it to the history list.
                currentHistory = NewStepHistory(executionContext, transactionId, currentStep, startingHistory);
                historyList.Add(currentHistory);
            }

            // Update the starting history in the database.
            if (startingHistory != null)
            {
                startingHistory.NextStepId = currentHistory;
                DataConnector.UpdateStepHistoryRecord(
                    executionContext.DataService,
                    startingHistory,
                    currentHistory,
                    workSession.Agent,
                    workSession.Location,
                    DateTime.Now);
            }
        }

        public void ArchiveStepHistory(IProcessExecutionContext executionContext, IList<IStepHistory> historyList, IRecordPointer<Guid> historyId, bool stepRolledBack = false)
        {
            throw new NotImplementedException();
        }

        public IList<IStepHistory> LoadStepHistory(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, TimeSpan? cacheTimeout = null)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");

            string cacheKey = null;

            if (executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = CACHE_KEY + transactionId.Id.ToString();
            }

            if (cacheKey != null)
            {
                if (executionContext.Cache.Exists(CACHE_KEY))
                {
                    return executionContext.Cache.Get<IList<IStepHistory>>(cacheKey);
                }
            }

            var records = DataConnector.QueryTransactionStepHistory(executionContext.DataService, transactionId);

            if(cacheKey != null)
            {
                executionContext.Cache.Add<IList<IStepHistory>>(CACHE_KEY, records, cacheTimeout.Value);
            }

            return records;

        }

      

        public IStepHistory NewStepHistory(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> processStepId, IRecordPointer<Guid> previousStepHistoryId)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (transactionId is null) throw new ArgumentNullException("transactionId");
            if (processStepId is null) throw new ArgumentNullException("processStepId");

            return DataConnector.CreateStepHistoryRecord(executionContext.DataService, transactionId, processStepId, previousStepHistoryId);
        }
       
    }
}
