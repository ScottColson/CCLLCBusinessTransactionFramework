using System;
using System.Collections.Generic;
using System.Linq;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;
    using CCLLC.BTF.Revenue;
    using CCLLC.BTF.Documents;

    public class Transaction : RecordPointer<Guid>, ITransaction
    {
        private List<IDataOfRecord> _affectedRecords;
        private List<IAppliedFee> _appliedFees;
        private List<ICollectedEvidence> _collectedEvidence;
        private List<IStepHistory> _stepHistory;
        private List<IRequirementDeficiency> _deficiencies;
        private List<IGeneratedDocument> _generatedDocuments;

        #region Protected Contructor Properties

        protected IProcessExecutionContext ExecutionContext { get; }

        protected IAgentFactory AgentFactory { get; }
        protected IAppliedFeeManager AppliedFeeManager { get; }
        protected ITransactionContextFactory TransactionContextFactory { get; }
        protected ICustomerFactory CustomerFactory { get; }
        protected IDeficiencyManager DeficiencyManager { get; }
        protected IDocumentManager DocumentManager { get; }
        protected IEvidenceManager EvidenceManager { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IRequirementEvaluator RequirementEvaluator { get; }
        protected IStepHistoryManager StepHistoryManager { get; }
        protected ITransactionManager TransactionManager { get; }
      
        protected IRecordPointer<Guid> ContextRecordId { get; }
        protected IRecordPointer<Guid> CustomerId { get;  }
        protected IRecordPointer<Guid> CurrentProcessId { get; }
        protected IRecordPointer<Guid> CurrentStepId { get; private set; }
        protected IRecordPointer<Guid> InitiatingAgentId { get;  }
        protected IRecordPointer<Guid> InitiatingLocationId { get;  }
        protected IRecordPointer<Guid> InitiatingProcessId { get;  }
       
        #endregion

        

        public string Name { get; }

        private ICustomer _customer;
        public ICustomer Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = CustomerFactory.CreateCustomer(ExecutionContext, CustomerId);
                }

                return _customer;
            }
        }

        public string ReferenceNumber { get;  }

        public ITransactionType TransactionType { get;  }

        private IAgent _initiatingAgent;
        public IAgent InitiatingAgent
        {
            get
            {
                if(_initiatingAgent == null) { _initiatingAgent = AgentFactory.BuildAgent(ExecutionContext, InitiatingAgentId); }

                return _initiatingAgent;
            }
        }

        private ILocation _initiatingLocation;
        public ILocation InitiatingLocation
        {
            get
            {
                if (_initiatingLocation == null)
                {
                    _initiatingLocation = LocationFactory.CreateLocation(ExecutionContext, InitiatingLocationId);
                }

                return _initiatingLocation;
            }
        }

        public ITransactionProcess InitiatingProcess
        {
            get
            {
                var process = TransactionType.AvailableProcesses.Where(p => p.Id == InitiatingProcessId.Id).FirstOrDefault();

                if (process == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNotFound);

                return process;
            }
        }        

        public ITransactionProcess CurrentProcess
        {
            get
            {
                var process = TransactionType.AvailableProcesses.Where(p => p.Id == CurrentProcessId.Id).FirstOrDefault();

                if (process == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNotFound);

                return process;
            }
        }

        public IProcessStep CurrentStep
        {
            get
            {
                var process = CurrentProcess;
                var step = CurrentProcess.ProcessSteps.Where(s => s.Id == CurrentStepId.Id).FirstOrDefault();

                if (step == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);

                return step;
            }
        }

        private ITransactionContext _transactionContext;
        public ITransactionContext TransactionContext
        {
            get
            {
                if (_transactionContext == null)
                {
                    _transactionContext = TransactionContextFactory.CreateTransactionContext(this.ExecutionContext, this.ContextRecordId);
                }

                return _transactionContext;
            }
        }

        public ITransactionDataRecord DataRecord
        {
            get
            {
                var recordType = this.TransactionType.TransactionDataRecordType;
                return this.TransactionManager.LoadTransactionDataRecord(this.ExecutionContext, this);
            }
        }

        public IReadOnlyList<IDataOfRecord> AffectedRecords
        {
            get
            {
                if (_affectedRecords == null)
                {
                   _affectedRecords = this.TransactionManager.LoadAffectedRecords(this.ExecutionContext, this, this.TransactionType.AffectedRecordTypes).ToList();
                }

                return _affectedRecords;
            }
        }

        public IReadOnlyList<IAppliedFee> AppliedFees
        {
            get
            {
                if (_appliedFees == null)
                {
                    _appliedFees = this.AppliedFeeManager.LoadAppliedFees(this.ExecutionContext, this).ToList();
                }

                return _appliedFees;
            }
        }

        public IReadOnlyList<ICollectedEvidence> CollectedEvidence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IStepHistory> StepHistory
        {
            get
            {
                if (_stepHistory == null)
                {
                    _stepHistory = StepHistoryManager.LoadStepHistory(this.ExecutionContext, this).ToList();
                }

                return _stepHistory;
            }
        }

        public IReadOnlyList<IRequirementDeficiency> Deficiencies
        {
            get
            {
                if (_deficiencies == null)
                {
                    _deficiencies = this.DeficiencyManager.LoadDeficiencies(this.ExecutionContext, this.Id).ToList();
                }

                return _deficiencies;
            }
        }

        public IReadOnlyList<IGeneratedDocument> GeneratedDocuments
        {
            get
            {
                if (_generatedDocuments == null)
                {
                    _generatedDocuments = this.DocumentManager.LoadGeneratedDocuments(this.ExecutionContext, this).ToList();
                }

                return _generatedDocuments;
            }
        }

        

        public Transaction(IProcessExecutionContext executionContext, IAgentFactory agentFactory, IAppliedFeeManager appliedFeeManager, ITransactionContextFactory transactionContextFactory,
            ICustomerFactory customerFactory, IDeficiencyManager deficiencyManager, IDocumentManager documentManager, IEvidenceManager evidenceManager, 
            ILocationFactory locationFactory, IRequirementEvaluator requirementEvaluator, IStepHistoryManager stepHistoryManager, ITransactionManager transactionManager,  
            ITransactionType transactionType, ITransactionRecord record) 
            : base(record.RecordType,record.Id)
        {            
            this.ExecutionContext = executionContext ?? throw new ArgumentNullException("executionContext");

            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory");
            this.AppliedFeeManager = appliedFeeManager ?? throw new ArgumentNullException("appliedFeeManager");
            this.TransactionContextFactory = transactionContextFactory ?? throw new ArgumentNullException("transactionContextFactory");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory");
            this.DeficiencyManager = deficiencyManager ?? throw new ArgumentNullException("deficiencyManager");
            this.DocumentManager = documentManager ?? throw new ArgumentNullException("documentManager");
            this.EvidenceManager = evidenceManager ?? throw new ArgumentNullException("evidenceManager");
            this.LocationFactory = locationFactory ?? throw new ArgumentNullException("locationFactory");
            this.RequirementEvaluator = requirementEvaluator ?? throw new ArgumentNullException("requirementEvaluator");
            this.StepHistoryManager = stepHistoryManager ?? throw new ArgumentNullException("stepHistoryFactory");
            this.TransactionManager = transactionManager ?? throw new ArgumentNullException("transactionManager");
            
            this.TransactionType = transactionType ?? throw new ArgumentNullException("transactionType");
                       
            this.Name = record.Name;
            this.ReferenceNumber = record.ReferenceNumber;
            this.InitiatingProcessId = record.InitiatingProcessId ?? throw new ArgumentNullException("InitiatingProcessId");
            this.CurrentProcessId = record.CurrentProcessId ?? throw new ArgumentNullException("CurrentProcessId");
            this.CurrentStepId = record.CurrentStepId ?? throw new ArgumentNullException("CurrentStepId");
            this.ContextRecordId = record.ContextRecordId ?? throw new ArgumentNullException("contextRecordId");
            this.CustomerId = record.CustomerId ?? throw new ArgumentNullException("customerId");
            this.InitiatingAgentId = record.InitiatingAgentId ?? throw new ArgumentNullException("initiatingAgentId");
            this.InitiatingLocationId = record.InitiatingLocationId ?? throw new ArgumentNullException("initiatingLocationId");
            
        }

      

        public bool CanJumpTo(IWorkSession session, IStepHistory step) => false;

        public bool CanNavigateBackward(IWorkSession session) => GetPreviousUIStep(this.CurrentStep) != null;

        public bool CanNavigateForward(IWorkSession session) => this.CurrentStep != null && !this.CurrentStep.IsLastStep();

        /// <summary>
        /// Jump to the specified step in the <see cref="ITransactionProcess"/>.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="processHistoryStep"></param>
        /// <returns></returns>
        public IProcessStep JumpTo(IWorkSession session, IStepHistory processHistoryStep)
        {
            if (!this.CanJumpTo(session, processHistoryStep)) throw TransactionException.BuildException(TransactionException.ErrorCode.ActionNotAvailable);

            var processStep = GetProcessStepById(processHistoryStep.ProcessStepId);

            if (processStep is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);

            return processStep;
        }

        /// <summary>
        /// Navigate the <see cref="ITransactionProcess"/> back to the previously completed UI step.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public IProcessStep NavigateBackward(IWorkSession session)
        {
            try
            {
                if (!this.CanNavigateBackward(session)) throw TransactionException.BuildException(TransactionException.ErrorCode.ActionNotAvailable);

                // Get history for the current step and the UI step we are navigating back to.               
                IStepHistory currentStepHistory = GetProcessStepHistory(this.CurrentStep);
                IStepHistory prevStepHistory = GetPreviousUIHistory(this.CurrentStep);

                // Start a new history branch by creating a new history connection between the
                // original predecessor step history and the new history. 
                IProcessStep nextProcessStep = GetProcessStepFromHistory(prevStepHistory);
                IProcessStep branchingProcessStep = null;
                if (prevStepHistory.PreviousStepId != null)
                {
                    branchingProcessStep = GetProcessStepFromHistory(prevStepHistory.PreviousStepId);
                }                
                this.StepHistoryManager.GenerateStepHistory(this.ExecutionContext, _stepHistory, this, session, branchingProcessStep, nextProcessStep);

                
               
                // Archive the step history between previous history and the history associated with the step we are leaving.
                var archiveStepHistory = prevStepHistory;
                while (archiveStepHistory != null)
                {
                    //Rollback step execution if that is supported.
                    bool rolledBack = false;
                    if(archiveStepHistory.CompletedOn.HasValue)
                    {                        
                        var step = this.CurrentProcess.ProcessSteps.Where(s => s.Id == archiveStepHistory.PreviousStepId.Id).FirstOrDefault();
                        if (step.Type.IsReversable)
                        {
                            step.Rollback(this.ExecutionContext, session, this);
                            rolledBack = true;
                        }
                    }

                    //archive this history record.
                    this.StepHistoryManager.ArchiveStepHistory(this.ExecutionContext, _stepHistory, archiveStepHistory, rolledBack);

                    //get next record to archive for loop
                    if (archiveStepHistory.Id != currentStepHistory.Id && archiveStepHistory.PreviousStepId != null)
                    {
                        archiveStepHistory = _stepHistory.Where(e => e.Id == archiveStepHistory.PreviousStepId.Id).FirstOrDefault();
                    }
                    else
                    {
                        archiveStepHistory = null;
                    }
                }

                
                // Update the transaction with the new current step
                this.CurrentStepId = nextProcessStep;
                this.TransactionManager.SaveTransactionCurrentStep(this.ExecutionContext, this, this.CurrentStepId);

                return this.CurrentStep;
            }
            catch(Exception ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNavigationError, ex);
            }
        }

        public IProcessStep NavigateForward(IWorkSession session)
        {
            try
            {
                if (!this.CanNavigateForward(session)) throw TransactionException.BuildException(TransactionException.ErrorCode.ActionNotAvailable);

                // If the navigation gets blocked by a validation issue then the navigation process must fall back to the step 
                // it started on.
                var fallbackStepId = this.CurrentStepId;

                IProcessStep startingStep = this.CurrentStep;
                IProcessStep nextStep = null;
                bool isBlocked = false;

                while (true)
                {
                    // Get the step history record for the starting step. This record should always exist.  
                    IStepHistory stepHistory = GetProcessStepHistory(startingStep);
                    if (stepHistory is null) throw TransactionException.BuildException(TransactionException.ErrorCode.StepHistoryNotFound);
                                        
                    bool hasExecuted = stepHistory.CompletedOn.HasValue;

                    if (!hasExecuted)
                    {
                        ExecutionContext.Trace("Getting next step by executing current step.");

                        // When the step has not been executed we need to execute it to find out what the next step in the 
                        // processes is because steps with conditional branching do not know the next step until execution.
                        //
                        // Additionally, any validation requirements associated with the step will be evaluated and this could 
                        // result in blocking forward navigation. In this case we still update the step history to show that the 
                        // step was executed.
                        var executionResult = startingStep.Execute(ExecutionContext, session, this, RequirementEvaluator);
                        nextStep = executionResult.NextStep;
                        isBlocked = executionResult.StepIsBlocked; //valdiation requirements may block further advancemennt.

                        // Update the step history for this process step transition. This creates a new step history for the "next step" and 
                        // links up the history from the current step.
                        this.StepHistoryManager.GenerateStepHistory(this.ExecutionContext, _stepHistory, this, session, startingStep, nextStep);
                    }
                    else
                    {
                        ExecutionContext.Trace("Getting next step from step history");

                        if (stepHistory.NextStepId is null) throw TransactionException.BuildException(TransactionException.ErrorCode.StepHistoryInvalid);

                        // When the step has executed then we just get the next step based on history.
                        nextStep = GetProcessStepFromHistory(stepHistory.NextStepId);
                    }

                    // Stop moving forward when a UI step is found or when the step represents the last step in the process or
                    // when additional execution is blocked.
                    if (isBlocked || nextStep is null || nextStep.IsLastStep() || nextStep.Type.IsUIStep)
                    {
                        break;
                    }

                    // advance to the next process step and run through the loop again
                    startingStep = nextStep;

                }

                // When any execution in this step is blocked because of validation then the process falls back to 
                // the step that was current before we started. However any items that were completed in the above loop
                if (isBlocked)
                {
                    this.CurrentStepId = fallbackStepId;
                    return this.CurrentStep;
                }

                // save the current step to the data base.
                this.CurrentStepId = nextStep;
                this.TransactionManager.SaveTransactionCurrentStep(this.ExecutionContext, this, this.CurrentStepId);

                return this.CurrentStep;
            }            
            catch(Exception ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNavigationError, ex);
            }
        }

        /// <summary>
        /// Returns the <see cref="IProcessStep"/> associated with the <see cref="IProcessStepHistory"/> identified
        /// by the supplied process history record id.
        /// </summary>
        /// <param name="processHistoryId"></param>
        /// <returns></returns>
        private IProcessStep GetProcessStepFromHistory(IRecordPointer<Guid> processHistoryId)
        {
            var historyStep = GetStepHistoryById(processHistoryId);

            if (historyStep is null) throw TransactionException.BuildException(TransactionException.ErrorCode.StepHistoryNotFound);

            var processStep = GetProcessStepById(historyStep.ProcessStepId);

            if (processStep is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);

            return processStep;
        }

        /// <summary>
        /// Searches <see cref="StepHistory"/> to find the UI step that was completed prior to the identified 
        /// <see cref="IProcessStep"/>. Returns null if no previous UI step is found.
        /// </summary>
        /// <param name="processStep"></param>
        /// <returns></returns>
        private IProcessStep GetPreviousUIStep(IProcessStep processStep)
        {
            var previousUIHistory = GetPreviousUIHistory(processStep);
            if(previousUIHistory is null)  return null;

            IProcessStep previousProcessStep = GetProcessStepById(previousUIHistory.ProcessStepId);
            return previousProcessStep;
        }


        private IStepHistory GetPreviousUIHistory(IProcessStep processStep)
        {
            //get the transaction step that is linked to to the specified process step if it exists.
            var matchingStepHistory = GetProcessStepHistory(processStep);

            if (matchingStepHistory == null) return null;

            var previousHistoryId = matchingStepHistory.PreviousStepId;
            while (previousHistoryId != null)
            {
                IStepHistory historyStep = GetStepHistoryById(previousHistoryId);
                IProcessStep previousProcessStep = GetProcessStepById(historyStep.ProcessStepId);

                if (previousProcessStep.Type.IsUIStep) return historyStep;
            }

            return null;
        }


        /// <summary>
        /// Searches <see cref="StepHistory"/> and returns the most recent current <see cref="IStepHistory"/> record associated 
        /// with the specified <see cref="IProcessStep"/>. Returns null if no current step history record is found.
        /// </summary>
        /// <param name="processStep"></param>
        /// <returns></returns>
        private IStepHistory GetProcessStepHistory(IProcessStep processStep)
        {
            if (processStep is null) return null;

            //get the transaction step that is linked to to the specified process step if it exists.
            return this.StepHistory
                .Where(t => t.ProcessStepId.Id == processStep.Id
                    && t.StepStatus == eProcessStepHistoryStatusEnum.Current)
                .OrderBy(r => r.CompletedOn)
                .FirstOrDefault();
        }

        /// <summary>
        /// Returns the <see cref="IStepHistory"/> specfieid with the supplied id value.
        /// </summary>
        /// <param name="stepHistoryId"></param>
        /// <returns></returns>
        private IStepHistory GetStepHistoryById(IRecordPointer<Guid> stepHistoryId)
        {
            var stepHistory = this.StepHistory.Where(s => s.Id == stepHistoryId.Id).FirstOrDefault();

            if (stepHistory is null) throw TransactionException.BuildException(TransactionException.ErrorCode.StepHistoryNotFound);

            return stepHistory;
        }

        /// <summary>
        /// Returns the <see cref="IProcessStep"/> associated with the specified id value.
        /// </summary>
        /// <param name="processStepId"></param>
        /// <returns></returns>
        private IProcessStep GetProcessStepById(IRecordPointer<Guid> processStepId)
        {
            var step = this.CurrentProcess.ProcessSteps.Where(s => s.Id == processStepId.Id).FirstOrDefault();
            if (step is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);
            return step;
        }

     
    }
}