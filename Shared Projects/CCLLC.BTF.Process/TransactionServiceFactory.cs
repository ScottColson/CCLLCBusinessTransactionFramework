using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Documents;


namespace CCLLC.BTF.Process
{
    public class TransactionServiceFactory : ITransactionServiceFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.Process.TransactionServiceFactory";

        protected ITransactionDataConnector DataConnector { get; }
        protected IAgentFactory AgentFactory { get; }
        protected IAlternateBranchFactory AlternateBranchFactory { get; }
        protected ITransactionFeeListFactory TransactionFeeListFactory { get; }
        protected ITransactionContextFactory TransactionContextFactory { get; }
        protected ICustomerFactory CustomerFactory { get; }
        protected ITransactionDeficienciesFactory TransactionDeficienciesFactory { get; }
        protected IDocumentService DocumentService { get; }
        protected ILogicEvaluatorTypeFactory EvaluatorTypeFactory { get; }
        protected IEvidenceService EvidenceService { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IPlatformService PlatformService { get; }
        protected IProcessStepFactory ProcessStepFactory { get; }
        protected IProcessStepTypeFactory ProcessStepTypeFactory { get; }
        protected IRequirementEvaluator RequirementEvaluator { get; }
        protected IRequirementFactory RequirementFactory { get; }
        protected ITransactionHistoryFactory TransactionHistoryFactory { get; }
        protected ITransactionProcessFactory TransactionProcessFactory { get; }
        protected IParameterSerializer ParameterSerializer { get; }
        protected IFeeList FeeList { get; }
        protected IProcessSettingsFactory SettingsFactory { get; }


        public TransactionServiceFactory(IProcessSettingsFactory settingsFactory, ITransactionDataConnector dataConnector, IAgentFactory agentFactory, IAlternateBranchFactory alternateBranchFactory, 
            ITransactionFeeListFactory transactionFeeListFactory, ITransactionContextFactory transactionContextFactory, ICustomerFactory customerFactory, ITransactionDeficienciesFactory transactionDeficienciesFactory, 
            IDocumentService documentService, ILogicEvaluatorTypeFactory evaluatorTypeFactory, IEvidenceService evidenceService, ILocationFactory locationFactory, 
            IParameterSerializer parameterSerializer, IPlatformService platformService, IProcessStepFactory processStepFactory, IProcessStepTypeFactory processStepTypeFactory, 
            IRequirementEvaluator requirementEvaluator, IRequirementFactory requirementFactory, ITransactionHistoryFactory transactionHistoryFactory, 
            ITransactionProcessFactory transactionProcessFactory, IFeeList feeList)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory.");
            this.AlternateBranchFactory = alternateBranchFactory ?? throw new ArgumentNullException("alternateBrachFactory");
            this.TransactionFeeListFactory = transactionFeeListFactory ?? throw new ArgumentNullException("transactionFeeListFactory");
            this.TransactionContextFactory = transactionContextFactory ?? throw new ArgumentNullException("transactionContextFactory");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory.");
            this.TransactionDeficienciesFactory = transactionDeficienciesFactory ?? throw new ArgumentNullException("transactionDeficienciesFactory");
            this.DocumentService = documentService ?? throw new ArgumentNullException("documentService");
            this.EvaluatorTypeFactory = evaluatorTypeFactory ?? throw new ArgumentNullException("evaluatorTypeFactory.");
            this.EvidenceService = evidenceService ?? throw new ArgumentNullException("evidenceService");
            this.LocationFactory = locationFactory ?? throw new ArgumentNullException("locationFactory.");
            this.PlatformService = platformService ?? throw new ArgumentNullException("platformService.");
            this.ProcessStepFactory = processStepFactory ?? throw new ArgumentNullException("processStepFactory.");
            this.ProcessStepTypeFactory = processStepTypeFactory ?? throw new ArgumentNullException("processStepTypeFactory.");
            this.RequirementEvaluator = requirementEvaluator ?? throw new ArgumentNullException("requirementEvaluator");
            this.RequirementFactory = requirementFactory ?? throw new ArgumentNullException("requirementFactory.");
            this.TransactionHistoryFactory = transactionHistoryFactory ?? throw new ArgumentNullException("transactionHistoryFactory");
            this.TransactionProcessFactory = transactionProcessFactory ?? throw new ArgumentNullException("transactionProcessFactory.");
            this.ParameterSerializer = parameterSerializer ?? throw new ArgumentNullException("parameterSerializer");
            this.FeeList = feeList ?? throw new ArgumentNullException("feeList");
        }

        /// <summary>
        /// Builds a new Transaction Service preloaded with all available Transaction Type configurations.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="cacheTimeOut">Sets amount of time to cache the transaction service to service future build requests. When null, caching is not used.</param>
        /// <returns></returns>
        public ITransactionService CreateTransactionService(IProcessExecutionContext executionContext, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

            if (useCache)
            {
                if (executionContext.Cache.Exists(CACHE_KEY))
                {
                    executionContext.Trace("Returning Transaction Service from cache.");
                    return executionContext.Cache.Get<ITransactionService>(CACHE_KEY);
                }
            }

           

                IList<ITransactionType> registeredTransactions = new List<ITransactionType>();
                                
                var transactionTypeRecords = DataConnector.GetAllTransactionTypeRecords(executionContext.DataService);   
                executionContext.Trace("Retrieved {0} Transaction Type records.", transactionTypeRecords.Count);

                // get all active records that are needed to fully define a transaction type. This includes complex objects for ITransactionProcess 
                // and ITransactionRequirements as well as simpler objects for transaction groups, authorized channels, authorized roles, 
                // initial fees, and eligible record contexts.
                var processes = getProcesses(executionContext, useCache);

                var requirements = getRequirements(executionContext, useCache);

                var transactionGroups = DataConnector.GetAllTransactionGroups(executionContext.DataService);
                executionContext.Trace("Retrieved {0} Transaction Group records.", transactionGroups.Count);

                var authorizedChannels = DataConnector.GetAllTransactionAuthorizedChannels(executionContext.DataService);   
                executionContext.Trace("Retrieved {0} Transaction Authorized Channel records.", authorizedChannels.Count);

                var authorizedRoles = DataConnector.GetAllAuthorizedRoles(executionContext.DataService);
                executionContext.Trace("Retrieved {0} Transaction Authorized Role records.", authorizedRoles.Count);

                var initialFees = DataConnector.GetAllInitialFees(executionContext.DataService);          
                executionContext.Trace("Retrieved {0} Transaction Initial Fee records.", initialFees.Count);

                var contexts = DataConnector.GetAllTransactionContextTypes(executionContext.DataService);
                executionContext.Trace("Retrieved {0} Transaction Type Context records.", contexts.Count);

                // Create a new TransactionType object for each transaction type retrieved.
                foreach (ITransactionTypeRecord t in transactionTypeRecords)
                {
                    executionContext.Trace("Processing transaction type '{0}'", t.Name);

                    ISerializedParameters dataRecordConfig = null;
                    try
                    {
                        executionContext.Trace("Parsing Data Record Configuration.");
                        dataRecordConfig = this.ParameterSerializer.CreateParamters(t.DataRecordConfiguration);
                        if (!dataRecordConfig.ContainsKey("RecordType")) throw new Exception("Missing RecordType.");
                        if (!dataRecordConfig.ContainsKey("CustomerField")) throw new Exception("Missing Customer Field");
                        if (!dataRecordConfig.ContainsKey("TransactionField")) throw new Exception("Missing Transaction Field");
                        if (!dataRecordConfig.ContainsKey("NameField")) throw new Exception("Missing Name Field");
                    }
                    catch(Exception ex)
                    {
                        throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeInvalid, ex);
                    }

                    registeredTransactions.Add(new TransactionType(
                        t,
                        t.Name,
                        t.DisplayRank,
                        transactionGroups.Where(r => t.TransactionGroupId != null && r.Id == t.TransactionGroupId.Id).FirstOrDefault(),
                        t.StartupProcessId ?? throw new Exception("Transaction type is missing a startup process id."),
                        dataRecordConfig,
                        authorizedChannels.Where(r => r.ParentId.Id == t.Id).Select(r => r.ChannelId),
                        authorizedRoles.Where(r => r.ParentId.Id == t.Id).Select(r => r.RoleId),
                        processes.Where(r => r.TransactionTypeId.Id == t.Id),
                        requirements.Where(r => r.TransactionTypeId.Id == t.Id),
                        initialFees.Where(r => r.TransactionTypeId.Id == t.Id).Select(r => r.FeeId),
                        contexts.Where(r => r.TransactionTypeId.Id == t.Id)));
                }

                executionContext.Trace("Creating Transaction Service loaded with {0} Transaction Types.", registeredTransactions.Count);

                // Create a new transaction service and pass in required factory and record services. 
                var transactionService = new TransactionService(this.DataConnector, this.AgentFactory, this.TransactionFeeListFactory, this.TransactionContextFactory, this.CustomerFactory, this.TransactionDeficienciesFactory,
                    this.DocumentService, this.EvidenceService,  this.LocationFactory, RequirementEvaluator,this.TransactionHistoryFactory, this.FeeList, registeredTransactions);

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    var cacheTimeout = settings.PlatformServiceCacheTimeout;

                    executionContext.Cache.Add<ITransactionService>(CACHE_KEY, transactionService, cacheTimeout.Value);
                    executionContext.Trace("Cached Transaction Service for {0}.", cacheTimeout.Value);
                }

                executionContext.TrackEvent("TransactionServiceFactory.BuildTransactionService");

                return transactionService;

            }
            catch (Exception)
            {
                throw;
            }

        }


        private IList<IRequirement> getRequirements(IProcessExecutionContext executionContext, bool useCache)
        {
            try
            {
                IList<IRequirement> registeredRequirements = new List<IRequirement>();
               
                var requirements = DataConnector.GetAllTransactionRequirements(executionContext.DataService);

                var waiverRoles = DataConnector.GetAllRequirementWaiverRoles(executionContext.DataService);

                foreach (var requirement in requirements)
                {
                    ILogicEvaluatorType evaluatorType = this.EvaluatorTypeFactory.BuildEvaluatorType(executionContext, requirement.EvaluatorTypeId, useCache);
                    
                    registeredRequirements.Add(
                        RequirementFactory.CreateRequirement(
                            executionContext, 
                            requirement as IRecordPointer<Guid>, 
                            requirement.Name, 
                            requirement.TypeFlag ?? eRequirementTypeFlags.Validation, 
                            requirement.TransactionTypeId, 
                            evaluatorType,
                            requirement.RequirementParameters, 
                            waiverRoles.Where(r => r.TransactionRequirementId != null && r.TransactionRequirementId.Id == requirement.Id).Select(r => r.RoleId), 
                            useCache));
                }

                return registeredRequirements;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns all registered <see cref="ITransactionProcess"/> items in the system. Each item is fully configured with all associated 
        /// <see cref="IProcessStep"/> items.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="cacheTimeout"></param>
        /// <returns></returns>
        private IList<ITransactionProcess> getProcesses(IProcessExecutionContext executionContext, bool useCache)
        {
            try
            {
                IList<ITransactionProcess> registeredProceses = new List<ITransactionProcess>();
               
                var processes = DataConnector.GetAllTransactionProcesses(executionContext.DataService);
                executionContext.Trace("Retrieved {0} Transaction Process records.", processes.Count);

                var processSteps = getProcessSteps(executionContext, useCache);

                foreach (var process in processes)
                {
                    executionContext.Trace("Building Transaction Process {0}", process.Name);
                    
                    var steps = processSteps.Where(s => s.TransactionProcessPointer.Id == process.Id);

                    registeredProceses.Add(
                        this.TransactionProcessFactory.CreateTransactionProcess(
                            executionContext, process,
                            process.Name,
                            process.TransactionTypeId ?? throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessInvalid), 
                            process.InitialProcessStepId ?? throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessInvalid),
                            steps, 
                            useCache));
                }

                return registeredProceses;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Returns all registered <see cref="IProcessStep"/> items in the system.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="cacheTimeout"></param>
        /// <returns></returns>
        private IList<IProcessStep> getProcessSteps(IProcessExecutionContext executionContext, bool useCache)
        {
            try
            {
                IList<IProcessStep> registeredSteps = new List<IProcessStep>();

                var steps = DataConnector.GetAllProcessSteps(executionContext.DataService);

                var stepChannels = DataConnector.GetAllStepAuthorizedChannels(executionContext.DataService);

                var stepTypes = DataConnector.GetAllStepTypes(executionContext.DataService);


                var stepRequirements = DataConnector.GetAllStepRequirements(executionContext.DataService);

                var alternateBranches = DataConnector.GetAlternateBranches(executionContext.DataService);

                var channels = PlatformService.GetChannels(executionContext, useCache);

                foreach (var step in steps)
                {
                    var stype = stepTypes.Where(r => r.Id == step.ProcessStepTypeId.Id).FirstOrDefault();

                    if (stype == null) { throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeNotFound); }

                    var processStepType = this.ProcessStepTypeFactory.CreateStepType(
                        executionContext, 
                        stype as IRecordPointer<Guid>, 
                        stype.Name, 
                        stype.SupportsConditionalBranching ?? false , 
                        stype.AssemblyName, 
                        stype.ClassName, 
                        useCache);

                    var assignedChannels = new List<IChannel>();
                    foreach (var c in stepChannels.Where(r => r.ParentId != null && r.ChannelId != null && r.ParentId.Id == step.Id))
                    {
                        var channel = channels.Where(r => r.Id == c.ChannelId.Id).FirstOrDefault();
                        assignedChannels.Add(channel);
                    }

                    var assignedRequirements = stepRequirements.Where(r => r.ProcessStepId != null && r.ProcessStepId.Id == step.Id);


                    var assignedBranches = new List<IAlternateBranch>();
                    foreach(var b in alternateBranches.Where(r => r.ParentStepId != null && r.ParentStepId.Id == step.Id))
                    {
                        var branch = AlternateBranchFactory.CreateAlternateBranch(
                            executionContext, 
                            b as IRecordPointer<Guid>, 
                            b.Name, 
                            b.EvaluationOrder,
                            b.ParentStepId, 
                            b.SubsequentStepId,
                            b.EvaluatorTypeId,
                            b.EvaluationParameters,
                            useCache);
                        assignedBranches.Add(branch);
                    }


                    var processStep = ProcessStepFactory.CreateProcessStep(
                        executionContext, 
                        step as IRecordPointer<Guid>, 
                        step.Name, 
                        step.TransactionProcessId,
                        processStepType, 
                        step.StepParameters,  
                        step.SubsequentStepId,
                        assignedBranches,
                        assignedChannels, 
                        assignedRequirements, 
                        useCache);

                    registeredSteps.Add(processStep);

                }

                return registeredSteps;
            }
            catch (Exception)
            {
                throw;
            }
                    
        }
    }
}
