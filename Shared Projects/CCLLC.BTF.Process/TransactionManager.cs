using System;
using System.Collections.Generic;
using System.Linq;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;
    using CCLLC.BTF.Platform;
    using CCLLC.BTF.Revenue;
    using CCLLC.BTF.Documents;

    public class TransactionManager : ITransactionManager
    {

        /// <summary>
        /// A list of existing <see cref="ITransactionType"/> items defined in the system. This 
        /// list is loaded when the <see cref="TransactionManager"/> is instantiated.
        /// </summary>
        public IReadOnlyList<ITransactionType> RegisteredTransactionTypes { get; }

        protected ITransactionDataConnector DataConnector { get;}
        protected IAgentFactory AgentFactory { get; }
        protected ITransactionFeeListFactory TransactionFeeListFactory { get; }
        protected ITransactionContextFactory TransactionContextFactory { get; }
        protected ICustomerFactory CustomerFactory { get; }
        protected ITransactionDeficienciesFactory TransactionDeficienciesFactory { get; }
        protected IDocumentManager DocumentManager { get; }
        protected IEvidenceManager EvidenceManager { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IRequirementEvaluator RequirementEvaluator { get; }
        protected ITransactionHistoryFactory TransactionHistoryFactory { get; }
        protected IFeeList FeeList { get; }

        protected internal TransactionManager(ITransactionDataConnector dataConnector, IAgentFactory agentFactory, ITransactionFeeListFactory transactionFeeListFactory, 
            ITransactionContextFactory transactionContextFactory, ICustomerFactory customerFactory, ITransactionDeficienciesFactory transactionDeficienciesFactory, IDocumentManager documentManager,
            IEvidenceManager evidenceManager, ILocationFactory locationFactory, IRequirementEvaluator requirementEvaluator, ITransactionHistoryFactory transactionHistoryFactory,
            IFeeList feeList,  IList<ITransactionType> registeredTransactions)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory");
            this.TransactionFeeListFactory = transactionFeeListFactory ?? throw new ArgumentNullException("feeListFactory");
            this.TransactionContextFactory = transactionContextFactory ?? throw new ArgumentNullException("transactionContextFactory");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory");
            this.TransactionDeficienciesFactory = transactionDeficienciesFactory ?? throw new ArgumentNullException("transactionDeficienciesFactory");
            this.DocumentManager = documentManager ?? throw new ArgumentNullException("documentManager");
            this.EvidenceManager = evidenceManager ?? throw new ArgumentNullException("evidenceManager");
            this.LocationFactory = locationFactory ?? throw new ArgumentNullException("locationFactory");
            this.RequirementEvaluator = requirementEvaluator ?? throw new ArgumentNullException("requirementEvaluator");
            this.TransactionHistoryFactory = transactionHistoryFactory ?? throw new ArgumentNullException("transactionHistoryFactory");
            this.FeeList = feeList ?? throw new ArgumentNullException("feeList");

            if (registeredTransactions == null)
            {
                this.RegisteredTransactionTypes = new List<ITransactionType>();
            }
            else
            {
                this.RegisteredTransactionTypes = registeredTransactions.ToList();
            }
        }

        /// <summary>
        /// Returns a list of registered transaction types that are applicable based on the current context record and the limitations
        /// imposed by the agent and channel associated with the work session.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="contextRecord"></param>
        /// <returns></returns>
        public IReadOnlyList<ITransactionType> GetAvaialbleTransactionTypes(IProcessExecutionContext executionContext, IWorkSession session, ITransactionContext transactionContext)
        {
            try
            {
                executionContext.Trace("Getting Transaction Types for context record type {0} and status {1}", transactionContext.RecordType, transactionContext.RecordStatus);

                var availableTransactions = RegisteredTransactionTypes
                    .Where(t => session.SupportsChannel(t.AuthorizedChannels)
                        && session.HasRole(t.AuthorizedRoles)
                        && session.CanOperateAgainstCustomer(transactionContext.Customer)
                        && transactionContext.IsContextType(t.EligibleContexts))
                .OrderBy(t => t.Group.DisplayRank)
                .ThenBy(t => t.Group.Name)
                .ThenBy(t => t.DisplayRank)
                .ThenBy(t => t.Name)
                .ToList();

                executionContext.Trace("Returning {0} eligible Transaction Types out of {1} registered Transaction Types", availableTransactions.Count, RegisteredTransactionTypes.Count);

                return availableTransactions;
            }
            catch(Exception)
            {
                throw;
            }
        }


        public ITransaction LoadTransaction(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (transactionId is null) throw new ArgumentNullException("transactionId");

                var transactionRecord = DataConnector.GetTransactionRecord(executionContext.DataService, transactionId);

                return buildTransaction(executionContext, transactionRecord);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public ITransaction NewTransaction(IProcessExecutionContext executionContext, IWorkSession workSession, ITransactionContext transactionContext, ITransactionType transactionType)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (workSession == null) throw new ArgumentNullException("workSession");
                if (transactionContext == null) throw new ArgumentNullException("transactionContext");
                if (transactionType == null) throw new ArgumentNullException("transactionType");

                if (workSession.Location == null) throw new ArgumentException("WorkSession is missing required Location.");
                if (workSession.Agent == null) throw new ArgumentException("WorkSession is missing required Agent.");

                if (transactionContext.Customer == null) throw new ArgumentException("Transaction context is missing required Customer.");

                var initialProcess = transactionType.AvailableProcesses.Where(r => r.Id == transactionType.StartUpProcessId.Id).FirstOrDefault();
                if (initialProcess == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNotFound);

                var initialStep = initialProcess.GetInitialStep();
                if (initialStep == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);

                ITransactionRecord transactionRecord = DataConnector.NewTransactionRecord(
                    executionContext.DataService,
                    workSession.Agent,
                    workSession.Location,
                    transactionContext.Customer,
                    transactionContext as IRecordPointer<Guid>,
                    transactionType,
                    initialProcess,
                    initialProcess,
                    initialStep,
                    transactionType.Name);        
                
                executionContext.TrackEvent("Created New Transaction");

                var transaction = buildTransaction(executionContext, transactionRecord);

                transaction.TransactionHistory.AddToHistory(executionContext, workSession, transaction.CurrentStep, false);

                //create transaction fees entries for any items on the initial fee schedule
                foreach (var feeId in transactionType.InitialFeeSchedule)
                {
                    var fee = FeeList.GetFee(executionContext, feeId);
                    transaction.Fees.AddFee(executionContext, workSession, fee);                   
                }

                return transaction;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ITransaction buildTransaction(IProcessExecutionContext executionContext, ITransactionRecord record)
        {
            if (record.TransactionTypeId is null) throw TransactionException.BuildException(TransactionException.ErrorCode.TransactionMissingTypeId);

            var transactionType = this.RegisteredTransactionTypes.Where(t => t.Id == record.TransactionTypeId.Id).FirstOrDefault();

            if (transactionType == null) throw TransactionException.BuildException(TransactionException.ErrorCode.TransactionTypeNotFound);
            
            // Create a new Transaction object and pass in all the factories and record managers needed to load related data as needed.
            ITransaction transaction = new Transaction(executionContext, this.AgentFactory, this.TransactionFeeListFactory, this.TransactionContextFactory, this.CustomerFactory,
                this.TransactionDeficienciesFactory, this.DocumentManager, this.EvidenceManager, this.LocationFactory, this.RequirementEvaluator, this.TransactionHistoryFactory,
                this as ITransactionManager, transactionType, record);
           
            return transaction;
        }

        public ITransactionDataRecord LoadTransactionDataRecord(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (transaction is null) throw new ArgumentNullException("transaction");
                               

                var dataRecordConfig = transaction.TransactionType.TransactionDataRecordType;
                if (dataRecordConfig is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeInvalid);

                var dataRecordType = dataRecordConfig["RecordType"];
                var nameField = dataRecordConfig["NameField"];
                var transactionField = dataRecordConfig["TransactionField"];
                var customerField = dataRecordConfig["CustomerField"];

                var record = DataConnector.GetFirstMatchingTransactionDataRecord(
                    executionContext.DataService,
                    transaction, 
                    dataRecordType, 
                    nameField, 
                    transactionField, 
                    customerField);

                if (record is null)
                {
                    record = DataConnector.NewTransactionDataRecord(
                        executionContext.DataService,
                        transaction, 
                        dataRecordType, 
                        nameField, 
                        transactionField, 
                        customerField, 
                        transaction.Name, 
                        transaction.Customer);

                    executionContext.Trace("Created new data record of type {0} for transaction {1}", dataRecordType, transaction.Id);
                }
                
                return record;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public IList<IDataOfRecord> LoadAffectedRecords(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IEnumerable<string> affectedRecordTypes)
        {
            throw new NotImplementedException("LoadAffectedRecords is not implemented");
        }

        public void SaveTransactionCurrentStep(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> currentStepId)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (transactionId is null) throw new ArgumentNullException("transactionId");
            if (currentStepId is null) throw new ArgumentNullException("currentStepId");

            DataConnector.UpdateTransactionRecord(
                executionContext.DataService,
                transactionId,
                currentStepId);     
        }
        
    }
}
