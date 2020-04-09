using System;
using Microsoft.Xrm.Sdk;
using CCLLC.CDS.Sdk;


/// <summary>
/// Defines various plugin processes that make setting up new transaction types, processes, and associated meta data records easier.
/// </summary>
namespace CCLLC.BTF.Process.CDS.Plugins
{    
    [CrmPluginRegistration(MessageNameEnum.Create, ccllc_transactiontype.EntityLogicalName, StageEnum.PreOperation, ExecutionModeEnum.Synchronous,
        "", "Transaction Type Setup Helper => On Create Transaction Type", 1001, IsolationModeEnum.Sandbox, Description = "Transaction Type Setup Helper => On Create Transaction Type",
        Id = "{4583F1B3-3D94-4B41-9579-39D79D004E92}")]
    [CrmPluginRegistration(MessageNameEnum.Create, ccllc_transactionprocess.EntityLogicalName, StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "Transaction Type Setup Helper => On Create Transaction Process", 1001, IsolationModeEnum.Sandbox, Description = "Transaction Type Setup Helper => On Create Transaction Process",
        Id = "{FCFB52A5-86A1-4802-A379-9D4299CDA229}")]
    [CrmPluginRegistration(MessageNameEnum.Create, ccllc_processstep.EntityLogicalName, StageEnum.PreOperation, ExecutionModeEnum.Synchronous,
        "", "Transaction Type Setup Helper => On Create Process Step (PreOp)", 1001, IsolationModeEnum.Sandbox, Description = "Transaction Type Setup Helper => On Create Process Step",
        Id = "{3B158756-F968-4BF1-9731-5FB20A5155E3}")]
    [CrmPluginRegistration(MessageNameEnum.Create, ccllc_processstep.EntityLogicalName, StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "Transaction Type Setup Helper => On Create Process Step (PostOp)", 1001, IsolationModeEnum.Sandbox, Description = "Transaction Type Setup Helper => On Create Process Step",
        Id = "{BAD806DE-E789-4D53-B3CE-D9447683D5CA}")]
    public class TransactionTypeSetupHelpers : PluginBase
    {
        public TransactionTypeSetupHelpers(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig)
        {
            RegisterCreateHandler<ccllc_transactiontype>(ePluginStage.PreOperation, addDataRecordParameterTemplate);

            RegisterCreateHandler<ccllc_transactionprocess>(ePluginStage.PostOperation, setTransactionTypeStartupProcessIfBlank);

            RegisterCreateHandler<ccllc_processstep>(ePluginStage.PreOperation, addStepParameterTemplate);
            RegisterCreateHandler<ccllc_processstep>(ePluginStage.PostOperation, addAsLastProcessStep);
        }

        /// <summary>
        /// Prior to a new transaction type record creation, set the data record configuration parameter
        /// to a template guide value if it is blank.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="target"></param>
        /// <param name="createdTransactionTypeId"></param>
        private void addDataRecordParameterTemplate(
            ICDSPluginExecutionContext executionContext,
            ccllc_transactiontype target,
            EntityReference createdTransactionTypeId)
        {
            if (target.ccllc_DataRecordConfiguration is null)
            {
                target.ccllc_DataRecordConfiguration =
                    "{" + Environment.NewLine +
                        "\"RecordType\":\"new_entitylogicalname\"," + Environment.NewLine +
                        "\"NameField\":\"new_name\"," + Environment.NewLine +
                        "\"TransactionField\":\"new_transactionid\"," + Environment.NewLine +
                        "\"CustomerField\":\"new_customerid\"" + Environment.NewLine +
                    "}";
            }
        }


        /// <summary>
        /// After a new transaction process is created, check the startup process value on the parent transaction type record
        /// and set it to this newly created transaction process if the value is currently blank.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="target"></param>
        /// <param name="createdProcessId"></param>
        private void setTransactionTypeStartupProcessIfBlank(
            ICDSPluginExecutionContext executionContext,
            ccllc_transactionprocess target,
            EntityReference createdProcessId)
        {
            if (target.ccllc_TransactionTypeId != null)
            {
                var transactionType = executionContext.OrganizationService
                    .GetRecord<ccllc_transactiontype>(target.ccllc_TransactionTypeId, cols => new { cols.Id, cols.ccllc_StartupProcessId });

                if (transactionType.ccllc_StartupProcessId is null)
                {
                    transactionType.ccllc_StartupProcessId = createdProcessId ?? throw new ArgumentNullException("createdProcessId is null");
                    executionContext.OrganizationService.Update(transactionType);
                }
            }
        }


        /// <summary>
        /// Prior to a new process step record creation, set the step parameter value to the template value
        /// defined on the associated step type if the value is currently blank.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="target"></param>
        /// <param name="createdProcessStepId"></param>
        private void addStepParameterTemplate(
            ICDSPluginExecutionContext executionContext,
            ccllc_processstep target,
            EntityReference createdProcessStepId)
        {
            if(target.ccllc_StepParameters == null && target.ccllc_ProcessStepTypeId != null)
            {
                var stepType = executionContext.OrganizationService
                    .GetRecord<ccllc_processsteptype>(target.ccllc_ProcessStepTypeId, cols => new { cols.Id, cols.ccllc_StepParameterTemplate });

                if(stepType.ccllc_StepParameterTemplate != null)
                {
                    target.ccllc_StepParameters = stepType.ccllc_StepParameterTemplate;
                }
            }
        }


        /// <summary>
        /// After creation of a new process step, link it up to the current last step in the process so that the
        /// new step becomes the last step in the process.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="target"></param>
        /// <param name="createdProcessStepId"></param>
        private void addAsLastProcessStep(
            ICDSPluginExecutionContext executionContext,
            ccllc_processstep target,
            EntityReference createdProcessStepId)
        {

            if (target.ccllc_TransactionProcessId != null)
            {
                var process = executionContext.OrganizationService
                    .GetRecord<ccllc_transactionprocess>(target.ccllc_TransactionProcessId, cols => new { cols.Id, cols.ccllc_InitialProcessStepId });

                // set the process initial step to this step if it is currently null.
                if (process.ccllc_InitialProcessStepId is null)
                {
                    process.ccllc_InitialProcessStepId = createdProcessStepId;
                    executionContext.OrganizationService.Update(process);
                }

                // find last step that has a blank subsequent step id that is not the newly created step.
                var lastStep = executionContext.OrganizationService.Query<ccllc_processstep>()
                    .Select(cols => new { cols.Id, cols.ccllc_SubsequentStepId })
                    .WhereAll(s => s
                        .IsActive()
                        .Attribute("ccllc_transactionprocessid").IsEqualTo(process.Id)
                        .Attribute("ccllc_subsequentstepid").IsNull()
                        .Attribute("ccllc_processstepid").Is(Microsoft.Xrm.Sdk.Query.ConditionOperator.NotEqual, createdProcessStepId.Id))
                    .OrderByDesc("createdon")
                    .FirstOrDefault();

                // Set the subsequent step on the last step to the newly created step.
                if (lastStep != null)
                {
                    lastStep.ccllc_SubsequentStepId = createdProcessStepId;
                    executionContext.OrganizationService.Update(lastStep);
                }
            }
        }


    }
}
