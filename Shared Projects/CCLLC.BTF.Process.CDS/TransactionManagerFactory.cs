using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Documents;
using Xrm.Oss.FluentQuery;

namespace CCLLC.BTF.Process.CDS
{
    public class TransactionManagerFactory : ITransactionManagerFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.Process.CDS.TransactionManagerFactory";

        protected ITransactionDataConnector DataConnector { get; }
        protected IAgentFactory AgentFactory { get; }
        protected IAlternateBranchFactory AlternateBranchFactory { get; }
        protected IAppliedFeeManager AppliedFeeManager { get; }
        protected ITransactionContextFactory TransactionContextFactory { get; }
        protected ICustomerFactory CustomerFactory { get; }
        protected IDeficiencyManager DeficiencyManager { get; }
        protected IDocumentManager DocumentManager { get; }
        protected ILogicEvaluatorTypeFactory EvaluatorTypeFactory { get; }
        protected IEvidenceManager EvidenceManager { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IPlatformManager PlatformManager { get; }
        protected IProcessStepFactory ProcessStepFactory { get; }
        protected IProcessStepTypeFactory ProcessStepTypeFactory { get; }
        protected IRequirementEvaluator RequirementEvaluator { get; }
        protected ITransactionRequirementFactory RequirementFactory { get; }
        protected IStepHistoryManager StepHistoryManager { get; }
        protected ITransactionProcessFactory TransactionProcessFactory { get; }
        protected IParameterSerializer ParameterSerializer { get; }


        public TransactionManagerFactory(ITransactionDataConnector dataConnector, IAgentFactory agentFactory, IAlternateBranchFactory alternateBranchFactory, 
            IAppliedFeeManager appliedFeeManager, ITransactionContextFactory transactionContextFactory, ICustomerFactory customerFactory, IDeficiencyManager deficiencyManager, 
            IDocumentManager documentManager, ILogicEvaluatorTypeFactory evaluatorTypeFactory, IEvidenceManager evidenceManager, ILocationFactory locationFactory, 
            IParameterSerializer parameterSerializer, IPlatformManager platformManager, IProcessStepFactory processStepFactory, IProcessStepTypeFactory processStepTypeFactory, 
            IRequirementEvaluator requirementEvaluator, ITransactionRequirementFactory requirementFactory, IStepHistoryManager stepHistoryManager, 
            ITransactionProcessFactory transactionProcessFactory)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.AgentFactory = agentFactory ?? throw new ArgumentNullException("agentFactory.");
            this.AlternateBranchFactory = alternateBranchFactory ?? throw new ArgumentNullException("alternateBrachFactory");
            this.AppliedFeeManager = appliedFeeManager ?? throw new ArgumentNullException("appliedFeeManager.");
            this.TransactionContextFactory = transactionContextFactory ?? throw new ArgumentNullException("transactionContextFactory");
            this.CustomerFactory = customerFactory ?? throw new ArgumentNullException("customerFactory.");
            this.DeficiencyManager = deficiencyManager ?? throw new ArgumentNullException("deficiencyManager");
            this.DocumentManager = documentManager ?? throw new ArgumentNullException("documentManager");
            this.EvaluatorTypeFactory = evaluatorTypeFactory ?? throw new ArgumentNullException("evaluatorTypeFactory.");
            this.EvidenceManager = evidenceManager ?? throw new ArgumentNullException("evidenceManager");
            this.LocationFactory = locationFactory ?? throw new ArgumentNullException("locationFactory.");
            this.PlatformManager = platformManager ?? throw new ArgumentNullException("platformManager.");
            this.ProcessStepFactory = processStepFactory ?? throw new ArgumentNullException("processStepFactory.");
            this.ProcessStepTypeFactory = processStepTypeFactory ?? throw new ArgumentNullException("processStepTypeFactory.");
            this.RequirementEvaluator = requirementEvaluator ?? throw new ArgumentNullException("requirementEvaluator");
            this.RequirementFactory = requirementFactory ?? throw new ArgumentNullException("requirementFactory.");
            this.StepHistoryManager = stepHistoryManager ?? throw new ArgumentNullException("stepHistoryManager");
            this.TransactionProcessFactory = transactionProcessFactory ?? throw new ArgumentNullException("transactionProcessFactory.");
            this.ParameterSerializer = parameterSerializer ?? throw new ArgumentNullException("parameterSerializer");
        }

        /// <summary>
        /// Builds a new Transaction Manager preloaded with all available Transaction Type configurations.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="cacheTimeOut">Sets amount of time to cache the transaction manager to service future build requests. When null, cacheing is not used.</param>
        /// <returns></returns>
        public ITransactionManager CreateTransactionManager(IProcessExecutionContext executionContext, TimeSpan? cacheTimeOut = null)
        {
            bool useCache = executionContext.Cache != null && cacheTimeOut != null;

            if (useCache)
            {
                if (executionContext.Cache.Exists(CACHE_KEY))
                {
                    executionContext.Trace("Returning Transaction Manager from cache.");
                    return executionContext.Cache.Get<ITransactionManager>(CACHE_KEY);
                }
            }

            try
            {

                IList<ITransactionType> registeredTransactions = new List<ITransactionType>();

                var orgService = executionContext.DataService.ToOrgService();

                // get all active transaction types that are registered.
                var transactionTypes = orgService.Query<ccllc_transactiontype>()
                   .IncludeAllColumns()
                   .Where(e => e.Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                   .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Type records.", transactionTypes.Count);

                // get all active records that are needed to fully define a transaction type. This includes complex objects for ITransactionProcess 
                // and ITransactionRequirements as well as simplier objects for transaction groups, authorized channels, authorized roles, 
                // initial fees, and eligible record contexts.
                var processes = getProcesses(executionContext, cacheTimeOut);

                var requirements = getRequirements(executionContext, cacheTimeOut);
               
                var transactionGroups = orgService.Query<ccllc_transactiongroup>()
                    .IncludeColumns("ccllc_transactiongroupid", "ccllc_name", "ccllc_displayrank")
                    .Where(e => e.Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Group records.", transactionGroups.Count);

                var authorizedChannels = orgService.Query<ccllc_transactiontypeauthorizedchannel>()
                     .IncludeColumns("ccllc_channelid", "ccllc_transactiontypeid")
                     .Where(e => e
                         .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                         .Attribute(a => a.Named("ccllc_channelid").Is(ConditionOperator.NotNull))
                         .Attribute(a => a.Named("ccllc_transactiontypeid").Is(ConditionOperator.NotNull)))
                     .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Authorized Channel records.", authorizedChannels.Count);

                var authorizedRoles = orgService.Query<ccllc_transactiontypeauthorizedrole>()
                    .IncludeColumns("ccllc_roleid", "ccllc_transactiontypeid")
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                        .Attribute(a => a.Named("ccllc_roleid").Is(ConditionOperator.NotNull))
                        .Attribute(a => a.Named("ccllc_transactiontypeid").Is(ConditionOperator.NotNull)))
                    .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Authorized Role records.", authorizedRoles.Count);

                var initialFees = orgService.Query<ccllc_transactioninitialfee>()
                    .IncludeColumns("ccllc_feeid", "ccllc_transactiontypeid")
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                        .Attribute(a => a.Named("ccllc_feeid").Is(ConditionOperator.NotNull))
                        .Attribute(a => a.Named("ccllc_transactiontypeid").Is(ConditionOperator.NotNull)))
                    .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Initial Fee records.", initialFees.Count);

                var contexts = orgService.Query<ccllc_transactiontypecontext>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                        .Attribute(a => a.Named("ccllc_transactiontypeid").Is(ConditionOperator.NotNull)))
                    .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Type Context records.", contexts.Count);

                // Create a new TransactionType object for each transaction type retrieved.
                foreach (var t in transactionTypes)
                {
                    executionContext.Trace("Processing transaction type '{0}'", t.ccllc_name);

                    ISerializedParameters dataRecordConfig = null;
                    try
                    {
                        executionContext.Trace("Parsing Data Record Configuration.");
                        dataRecordConfig = this.ParameterSerializer.CreateParamters(t.ccllc_DataRecordConfiguration);
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
                        t.ToRecordPointer(),
                        t.ccllc_name,
                        t.ccllc_DisplayRank.HasValue ? t.ccllc_DisplayRank.Value : 0,
                        transactionGroups.Where(r => t.ccllc_TransactionGroupId != null && r.Id == t.ccllc_TransactionGroupId.Id).FirstOrDefault(),
                        t.ccllc_StartupProcessId != null ? t.ccllc_StartupProcessId.Id : throw new Exception("Transaction type is missnig a startup process id."),
                        dataRecordConfig,
                        authorizedChannels.Where(r => r.ccllc_TransactionTypeId.Id == t.Id).Select(r => r.GetChannel()),
                        authorizedRoles.Where(r => r.ccllc_TransactionTypeId.Id == t.Id).Select(r => r.GetRole()),
                        processes.Where(r => r.TransactionTypeId.Id == t.Id),
                        requirements.Where(r => r.TransactionTypeId.Id == t.Id),
                        initialFees.Where(r => r.ccllc_TransactionTypeId.Id == t.Id).Select(r => r.GetFee()),
                        contexts.Where(r => r.ccllc_TransactionTypeId.Id == t.Id)));
                }

                executionContext.Trace("Creating Transaction Manager loaded with {0} Transaction Types.", registeredTransactions.Count);

                // Create a new transaction manager and pass in required factory and record managers. 
                var transactionManager = new TransactionManager(this.DataConnector, this.AgentFactory, this.AppliedFeeManager, this.TransactionContextFactory, this.CustomerFactory, this.DeficiencyManager,
                    this.DocumentManager, this.EvidenceManager,  this.LocationFactory, RequirementEvaluator,this.StepHistoryManager, registeredTransactions);

                if (useCache)
                {
                    executionContext.Cache.Add<ITransactionManager>(CACHE_KEY, transactionManager, cacheTimeOut.Value);
                    executionContext.Trace("Cached Transaction Manager for {0}.", cacheTimeOut.Value);
                }

                executionContext.TrackEvent("TransactionManagerFactory.BuildTransactionManager");

                return transactionManager;

            }
            catch (Exception)
            {
                throw;
            }

        }


        private IList<ITransactionRequirement> getRequirements(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout)
        {
            try
            {
                IList<ITransactionRequirement> registeredRequirements = new List<ITransactionRequirement>();

                var orgService = executionContext.DataService.ToOrgService();

                var requirements = orgService.Query<ccllc_transactionrequirement>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                        .Attribute(a => a.Named("ccllc_evaluatortypeid").Is(ConditionOperator.NotNull))
                        .Attribute(a => a.Named("ccllc_transactiontypeid").Is(ConditionOperator.NotNull)))
                    .RetrieveAll();

                var waiverRoles = orgService.Query<ccllc_transactionrequirementwaiverrole>()
                    .IncludeAllColumns()
                    .Where(e => e.Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll().Select(r => r.GetRole());

                foreach (var r in requirements)
                {
                    ILogicEvaluatorType evaluatorType = this.EvaluatorTypeFactory.BuildEvaluatorType(executionContext, r.ccllc_EvaluatorTypeId.ToRecordPointer(), cacheTimeout);
                    IEnumerable<OptionSetValue> options = (IEnumerable<OptionSetValue>)r.ccllc_TransactionRequirementTypeCode;

                    eTransactionRequirementTypeFlags? flags = null;
                    if (options != null)
                    {
                        foreach (var o in options)
                        {
                            var val = Enum.IsDefined(typeof(eTransactionRequirementTypeFlags), o.Value) ? (eTransactionRequirementTypeFlags)o.Value : throw new Exception("Invalid transaction requirement type.");
                            if (flags == null)
                            {
                                flags = val;
                            }
                            else
                            {
                                flags = flags & val;
                            }
                        }
                    }
                    
                    if(flags == null)
                    {
                        flags = eTransactionRequirementTypeFlags.Validation;
                    }

                    registeredRequirements.Add(RequirementFactory.CreateRequirement(executionContext, r.ToRecordPointer(), r.ccllc_name, flags, r.ccllc_TransactionTypeId.ToRecordPointer(), evaluatorType, r.ccllc_RequirementParameters, waiverRoles, cacheTimeout));
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
        private IList<ITransactionProcess> getProcesses(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout)
        {
            try
            {
                IList<ITransactionProcess> registeredProceses = new List<ITransactionProcess>();

                var orgService = executionContext.DataService.ToOrgService();

                var processes = orgService.Query<ccllc_transactionprocess>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll();

                executionContext.Trace("Retrieved {0} Transaction Process records.", processes.Count);

                var processSteps = getProcessSteps(executionContext, cacheTimeout);

                foreach (var p in processes)
                {
                    executionContext.Trace("Building Transaction Process {0}", p.ccllc_name);
                    if (p.ccllc_InitialProcessStepId is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessInvalid);
                    if (p.ccllc_TransactionTypeId is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessInvalid);

                    var steps = processSteps.Where(s => s.TransactionProcessPointer.Id == p.Id);

                    registeredProceses.Add(this.TransactionProcessFactory.CreateTransactionProcess(executionContext, p.ToRecordPointer(), p.ccllc_name, p.ccllc_TransactionTypeId.ToRecordPointer(), p.ccllc_InitialProcessStepId.ToRecordPointer(), steps, cacheTimeout));

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
        private IList<IProcessStep> getProcessSteps(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout)
        {
            try
            {
                IList<IProcessStep> registeredSteps = new List<IProcessStep>();

                var orgService = executionContext.DataService.ToOrgService();

                var steps = orgService.Query<ccllc_processstep>()
                   .IncludeAllColumns()
                   .Where(e => e
                       .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).Value(0))
                        .Attribute(a => a.Named("ccllc_processsteptypeid").Is(ConditionOperator.NotNull)))
                   .RetrieveAll();

                var stepTypes = orgService.Query<ccllc_processsteptype>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).Value<int>(0)))                       
                    .RetrieveAll();

                var stepChannels = orgService.Query<ccllc_processstepauthorizedchannel>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll();

                var stepRequirements = orgService.Query<ccllc_processsteprequirement>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll();

                var alternateBranches = orgService.Query<ccllc_alternatebranch>()
                    .IncludeAllColumns()
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .RetrieveAll();

                var channels = PlatformManager.GetChannels(executionContext, cacheTimeout);

                foreach (var s in steps)
                {
                    var stype = stepTypes.Where(r => r.Id == s.ccllc_ProcessStepTypeId.Id).FirstOrDefault();

                    if (stype == null) { throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepTypeNotFound); }

                    var processStepType = this.ProcessStepTypeFactory.CreateStepType(
                        executionContext, 
                        stype as IRecordPointer<Guid>, 
                        stype.ccllc_name, stype.ccllc_SupportsConditionalBranching.HasValue ? stype.ccllc_SupportsConditionalBranching.Value : false , 
                        stype.ccllc_AssemblyName, 
                        stype.ccllc_ClassName, 
                        cacheTimeout);

                    var assignedChannels = new List<IChannel>();
                    foreach (var c in stepChannels.Where(r => r.ccllc_ProcessStepId != null && r.ccllc_ChannelId != null && r.ccllc_ProcessStepId.Id == s.Id))
                    {
                        var channel = channels.Where(r => r.Id == c.ccllc_ChannelId.Id).FirstOrDefault();
                        assignedChannels.Add(channel);
                    }

                    var assignedRequirements = stepRequirements.Where(r => r.ccllc_ProcessStepId != null && r.ccllc_ProcessStepId.Id == s.Id);


                    var assignedBranches = new List<IAlternateBranch>();
                    foreach(var b in alternateBranches.Where(r => r.ccllc_ParentStepId != null && r.ccllc_ParentStepId.Id == s.Id))
                    {
                        var branch = AlternateBranchFactory.CreateAlternateBranch(
                            executionContext, 
                            b as IRecordPointer<Guid>, 
                            b.ccllc_name, 
                            b.ccllc_EvaluationOrder.HasValue ? b.ccllc_EvaluationOrder.Value : 0,
                            b.ccllc_ParentStepId?.ToRecordPointer(), 
                            b.ccllc_SubsequentStepId?.ToRecordPointer(),
                            b.ccllc_EvaluatorTypeId?.ToRecordPointer(),
                            b.ccllc_EvaluationParameters,
                            cacheTimeout);
                        assignedBranches.Add(branch);
                    }


                    var processStep = ProcessStepFactory.CreateProcessStep(
                        executionContext, 
                        s.ToRecordPointer(), 
                        s.ccllc_name, 
                        s.ccllc_TransactionProcessId != null ? s.ccllc_TransactionProcessId.ToRecordPointer() : null,
                        processStepType, 
                        s.ccllc_StepParameters,  
                        s.ccllc_SubsequentStepId != null? s.ccllc_SubsequentStepId.ToRecordPointer() : null,
                        assignedBranches,
                        assignedChannels, 
                        assignedRequirements, 
                        cacheTimeout);

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
