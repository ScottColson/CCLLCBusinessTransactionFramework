﻿using System;
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
        private ITransactionFeeList _transactionFeeList;
        private List<ICollectedEvidence> _collectedEvidence;
        private ITransactionHistory _transactionHistory;
        private ITransactionDeficiencies _deficiencies;
        private List<IGeneratedDocument> _generatedDocuments;

        #region Protected Constructor Properties

        protected IProcessExecutionContext ExecutionContext { get; }

        protected IAgentFactory AgentFactory { get; }
        protected ITransactionFeeListFactory TransactionFeeListFactory { get; }
        protected ITransactionContextFactory TransactionContextFactory { get; }
        protected ICustomerFactory CustomerFactory { get; }
        protected ITransactionDeficienciesFactory TransactionDeficienciesFactory { get; }
        protected IDocumentService DocumentService { get; }
        protected IEvidenceService EvidenceService { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IRequirementEvaluator RequirementEvaluator { get; }
        protected ITransactionHistoryFactory TransactionHistoryFactory { get; }
        protected ITransactionService TransactionService { get; }
      
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
                return this.TransactionService.LoadTransactionDataRecord(this.ExecutionContext, this);
            }
        }

        public IReadOnlyList<IDataOfRecord> AffectedRecords
        {
            get
            {
                if (_affectedRecords == null)
                {
                   _affectedRecords = this.TransactionService.LoadAffectedRecords(this.ExecutionContext, this, this.TransactionType.AffectedRecordTypes).ToList();
                }

                return _affectedRecords;
            }
        }

        public ITransactionFeeList Fees
        {
            get
            {
                if (_transactionFeeList == null)
                {
                    _transactionFeeList = TransactionFeeListFactory.CreateFeeList(ExecutionContext, this);
                }

                return _transactionFeeList;
            }
        }

        public IReadOnlyList<ICollectedEvidence> CollectedEvidence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITransactionHistory TransactionHistory
        {
            get
            {
                if (_transactionHistory == null)
                {
                    _transactionHistory = TransactionHistoryFactory.CreateTransactionHistory(this.ExecutionContext, this);
                }

                return _transactionHistory;
            }
        }

        public ITransactionDeficiencies Deficiencies
        {
            get
            {
                if (_deficiencies == null)
                {
                    _deficiencies = this.TransactionDeficienciesFactory.CreateTransactionDeficiencies(this.ExecutionContext, this);
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
                    _generatedDocuments = this.DocumentService.LoadGeneratedDocuments(this.ExecutionContext, this).ToList();
                }

                return _generatedDocuments;
            }
        }

        public DateTime PricingDate { get; }

        public Transaction(IProcessExecutionContext executionContext, IAgentFactory agentFactory, ITransactionFeeListFactory transactionFeeListFactory, ITransactionContextFactory transactionContextFactory,
            ICustomerFactory customerFactory, ITransactionDeficienciesFactory transactionDeficienciesFactory, IDocumentService documentService, IEvidenceService evidenceService, 
            ILocationFactory locationFactory, IRequirementEvaluator requirementEvaluator, ITransactionHistoryFactory transactionHistoryFactory, ITransactionService transactionService,  
            ITransactionType transactionType, ITransactionRecord record) 
            : base(record.RecordType,record.Id)
        {            
            this.ExecutionContext = executionContext ?? throw new ArgumentNullException("executionContext");

            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory");
            this.TransactionFeeListFactory = transactionFeeListFactory ?? throw new ArgumentNullException("transactionFeeListFactory");
            this.TransactionContextFactory = transactionContextFactory ?? throw new ArgumentNullException("transactionContextFactory");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory");
            this.TransactionDeficienciesFactory = transactionDeficienciesFactory ?? throw new ArgumentNullException("transactionDeficienciesFactory");
            this.DocumentService = documentService ?? throw new ArgumentNullException("documentService");
            this.EvidenceService = evidenceService ?? throw new ArgumentNullException("evidenceService");
            this.LocationFactory = locationFactory ?? throw new ArgumentNullException("locationFactory");
            this.RequirementEvaluator = requirementEvaluator ?? throw new ArgumentNullException("requirementEvaluator");
            this.TransactionHistoryFactory = transactionHistoryFactory ?? throw new ArgumentNullException("transactionHistoryFactory");
            this.TransactionService = transactionService ?? throw new ArgumentNullException("transactionService");
            
            this.TransactionType = transactionType ?? throw new ArgumentNullException("transactionType");
                       
            this.Name = record.Name;
            this.ReferenceNumber = record.ReferenceNumber;
            this.PricingDate = record.PricingDate ?? DateTime.Now.Date;
            this.InitiatingProcessId = record.InitiatingProcessId ?? throw new ArgumentNullException("InitiatingProcessId");
            this.CurrentProcessId = record.CurrentProcessId ?? throw new ArgumentNullException("CurrentProcessId");
            this.CurrentStepId = record.CurrentStepId ?? throw new ArgumentNullException("CurrentStepId");
            this.ContextRecordId = record.ContextRecordId ?? throw new ArgumentNullException("contextRecordId");
            this.CustomerId = record.CustomerId ?? throw new ArgumentNullException("customerId");
            this.InitiatingAgentId = record.InitiatingAgentId ?? throw new ArgumentNullException("initiatingAgentId");
            this.InitiatingLocationId = record.InitiatingLocationId ?? throw new ArgumentNullException("initiatingLocationId");            
        }

      
        public bool CanNavigateBackward(IWorkSession session) => this.TransactionHistory.GetReversingSteps()?.LastOrDefault() != null;

        public bool CanNavigateForward(IWorkSession session) => this.CurrentStep != null && !this.CurrentStep.IsLastStep();


        /// <summary>
        /// Navigate the <see cref="ITransactionProcess"/> back to the previously completed UI step.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public IProcessStep NavigateBackward(IWorkSession session)
        {
            try
            {
                var reversingSteps = this.TransactionHistory.GetReversingSteps();

                var lastReversingStep = reversingSteps?.LastOrDefault();

                if (lastReversingStep is null || !lastReversingStep.Type.IsUIStep) throw TransactionException.BuildException(TransactionException.ErrorCode.ActionNotAvailable);


                //archive existing history for all steps that are being reversed.
                foreach (var step in reversingSteps)
                {
                    bool isRolledBack = step.Rollback(this.ExecutionContext, session, this);
                    this.TransactionHistory.ArchiveHistoryForStep(this.ExecutionContext, session, step, isRolledBack);
                }

                this.TransactionHistory.AddToHistory(this.ExecutionContext, session, lastReversingStep, false);

                // Update the transaction with the new current step
                this.CurrentStepId = lastReversingStep;
                this.TransactionService.SaveTransactionCurrentStep(this.ExecutionContext, this, this.CurrentStepId);

                return this.CurrentStep;
            }
            catch (Exception ex)
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
                    IStepHistory stepHistory = this.TransactionHistory.GetHistoryForStep(startingStep);
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
                        isBlocked = executionResult.StepIsBlocked; //validation requirements may block further advancement.

                       this.TransactionHistory.AddToHistory(this.ExecutionContext, session, nextStep, true);
                    }
                    else
                    {
                        ExecutionContext.Trace("Getting next step from step history");

                        if (stepHistory.NextStepId is null) throw TransactionException.BuildException(TransactionException.ErrorCode.StepHistoryInvalid);

                        var nextStepId = this.TransactionHistory.GetHistoryById(stepHistory.NextStepId).ProcessStepId;

                        // When the step has executed then we just get the next step based on history.
                        nextStep = this.CurrentProcess.ProcessSteps.Where(r => Id == nextStepId.Id).FirstOrDefault();

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
                this.TransactionService.SaveTransactionCurrentStep(this.ExecutionContext, this, this.CurrentStepId);

                return this.CurrentStep;
            }            
            catch(Exception ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNavigationError, ex);
            }
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