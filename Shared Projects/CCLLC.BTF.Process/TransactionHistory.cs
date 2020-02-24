using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.BTF.Platform;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class TransactionHistory : ITransactionHistory
    {
        private IStepHistoryDataConnector DataConnector { get; }
        private ITransaction Transaction { get; }

        private IList<StepHistory> Records { get; }

        public TransactionHistory(IStepHistoryDataConnector dataConnector, ITransaction transaction, IList<IStepHistory> historyRecords)
        {
            
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.Transaction = transaction ?? throw new ArgumentNullException("transaction");
           

            if (historyRecords is null) throw new ArgumentNullException("historyRecords");

            this.Records = new List<StepHistory>();

            foreach(var record in historyRecords)
            {
                this.Records.Add(new StepHistory(record));
            }
        }

        public void AddToHistory(IProcessExecutionContext executionContext, IWorkSession session, IProcessStep processStep, bool isExecuted)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");           
            if (session is null) throw new ArgumentNullException("workSession");
            if (processStep is null) throw new ArgumentNullException("processStep");

            var lastHistory = this.Records.LastOrDefault();
            var lastCurrentHistory = this.Records.Where(r => r.StepStatus == eProcessStepHistoryStatusEnum.Current).LastOrDefault();

            //create a new history record for the passed in process step and 
            //link it back to last current history step in the list.
            var newHistory = DataConnector.CreateStepHistoryRecord(
                executionContext.DataService, 
                this.Transaction, 
                processStep, 
                lastCurrentHistory);

            this.Records.Add(new StepHistory(newHistory));

            // Update the starting history in the database.
            if (lastHistory != null)
            {
                //Update local copy.
                lastHistory.NextStepId = newHistory;                
                lastHistory.CompletedById = isExecuted ? session.Agent : null;
                lastHistory.CompletedAtId = isExecuted ? session.Location : null;

                //update database.
                DataConnector.UpdateStepHistoryRecord(
                  executionContext.DataService,
                  lastHistory,
                  newHistory,
                  isExecuted ? session.Agent : null,
                  isExecuted ? session.Location : null,
                  isExecuted ? (DateTime?)DateTime.Now : null);
            }
        }

        public void ArchiveHistoryForStep(IProcessExecutionContext executionContext, IWorkSession session, IProcessStep processStep, bool isRolledBack = false)
        {
            var historyRecord = GetHistoryForStep(processStep) as StepHistory;
            var statusCode = isRolledBack ? eProcessStepHistoryStatusEnum.RolledBack : eProcessStepHistoryStatusEnum.Archived;

            historyRecord.StepStatus = statusCode;
            DataConnector.UpdateStepHistoryStatus(executionContext.DataService, historyRecord, statusCode);
        }

        public IStepHistory GetHistoryById(IRecordPointer<Guid> stepHistoryId)
        {
            return getHistoryById(stepHistoryId);
        }

        public IStepHistory GetHistoryForStep(IProcessStep processStep)
        {
            return this.Records.Where(r =>
                r.StepStatus == eProcessStepHistoryStatusEnum.Current
                && r.ProcessStepId.Id == processStep.Id).FirstOrDefault() ?? throw new Exception("Unable to find current history for specified step.");
        }

        public IList<IProcessStep> GetReversingSteps()
        {
            var reversingSteps = new List<IProcessStep>();


            var stepHistory = this.Records.Where(r => r.StepStatus == eProcessStepHistoryStatusEnum.Current).LastOrDefault();

            reversingSteps.Add(getProcessStepForStepHistory(stepHistory));

            while(stepHistory.PreviousStepId != null)
            {
                stepHistory = getHistoryById(stepHistory.PreviousStepId);
                var processStep = getProcessStepForStepHistory(stepHistory);
                reversingSteps.Add(processStep);

                if (processStep.Type.IsUIStep) { break; }
            }

            // Validate the reversing steps. Must be 2 or more steps and first and last must be UI steps. If
            // invalid then clear the list.
            if (reversingSteps.Count < 2
                || !reversingSteps.First().Type.IsUIStep
                || !reversingSteps.Last().Type.IsUIStep)
            {
                reversingSteps.Clear();
            }
            
            return reversingSteps;
        }


        private StepHistory getHistoryById(IRecordPointer<Guid> stepHistoryId)
        {
            return this.Records.Where(r => r.Id == stepHistoryId.Id).FirstOrDefault() ?? throw new Exception("Cannot locate requested record in the list.");
        }

        private IProcessStep getProcessStepForStepHistory(IStepHistory stepHistory)
        {
            return this.Transaction.CurrentProcess.ProcessSteps.Where(r => r.Id == stepHistory.ProcessStepId.Id).FirstOrDefault();
        }

    }
}
