using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.CDS.Sdk;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process.CDS.Plugins
{
    [CrmPluginRegistration("ccllc_BTF_GetAvailableTransactionTypes", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_GetAvailableTransactionTypes Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_GetAvailableTransactionTypes", 
        Id = "{0AC8FBD1-854D-45E7-AC87-365FC5AD9C2C}")]
    [CrmPluginRegistration("ccllc_BTF_InitiateTransaction", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_InitiateTransaction Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_InitiateTransaction",
        Id = "{144DB698-EA1D-443E-95BA-A290AB9837A1}")]
    public class TransactionCreationActionHandler : PluginBase
    {
        public TransactionCreationActionHandler(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig)
        {
            RegisterEventHandler(null, "ccllc_BTF_GetAvailableTransactionTypes", ePluginStage.PostOperation, GetAvailableTransactionTypeHandler, "GetAvailableTransactionTypeHandler");
            RegisterEventHandler(null, "ccllc_BTF_InitiateTransaction", ePluginStage.PostOperation, InitiateTransactionHandler, "InitiateTransactionHandler");
        }

        internal void GetAvailableTransactionTypeHandler(ICDSPluginExecutionContext executionContext)
        {          
            var req = executionContext.CreateOrganizationRequest<ccllc_BTF_GetAvailableTransactionTypesRequest>();

            if (string.IsNullOrEmpty(req.ContextRecordType)) throw new ArgumentNullException("ContextRecordType cannot be null.");
            if (string.IsNullOrEmpty(req.ContextRecordId)) throw new ArgumentNullException("ContextRecordId cannot be null.");

            if(!Guid.TryParse(req.ContextRecordId,out Guid recordId))
            {
                throw new ArgumentException("ContextRecordId cannot be converted to a GUID.");
            }
            
            var contextRecordId = new RecordPointer<Guid>(req.ContextRecordType, recordId);

            var userId = req.UserId ?? new EntityReference("systemuser",executionContext.InitiatingUserId);           
            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();
            var session = platformManager.GenerateSession(executionContext, systemUser);

            var contextFactory = Container.Resolve<ITransactionContextFactory>();
            var transactionContext = contextFactory.CreateTransactionContext(executionContext, contextRecordId);
            
          
            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext);

            var available = manager.GetAvaialbleTransactionTypes(executionContext, session, transactionContext);
                       
            executionContext.OutputParameters["TransactionTypes"] = available.Serialize();
        }

        internal void InitiateTransactionHandler(ICDSPluginExecutionContext executionContext)
        {
            var req = (executionContext.CreateOrganizationRequest<ccllc_BTF_InitiateTransactionRequest>());

            if (string.IsNullOrEmpty(req.ContextRecordType)) throw new ArgumentNullException("ContextRecordType cannot be null.");
            if (string.IsNullOrEmpty(req.ContextRecordId)) throw new ArgumentNullException("ContextRecordId cannot be null.");

            if (!Guid.TryParse(req.ContextRecordId, out Guid recordId))
            {
                throw new ArgumentException("ContextRecordId cannot be converted to a GUID.");
            }

            var contextRecordId = new RecordPointer<Guid>(req.ContextRecordType, recordId);
            var transactionTypeId = req.TransactionTypeId ?? throw new NullReferenceException("TransactionTypeId cannot be null");
            var userId = req.UserId ?? new EntityReference("systemuser", executionContext.InitiatingUserId);
          
            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();

            var session = platformManager.GenerateSession(executionContext, systemUser);

            var contextFactory = Container.Resolve<ITransactionContextFactory>();
            var transactionContext = contextFactory.CreateTransactionContext(executionContext, contextRecordId);

            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext);

            var transactionType = manager.GetAvaialbleTransactionTypes(executionContext, session, transactionContext).Where(r => r.Id == transactionTypeId.Id).FirstOrDefault();

            if (transactionType == null) throw TransactionException.BuildException(TransactionException.ErrorCode.TransactionTypeNotFound);

            var transaction = manager.NewTransaction(executionContext, session, transactionContext, transactionType);

            IUIPointer uiPointer = null;

            if (transaction.CurrentStep.Type.IsUIStep)
            {
                uiPointer = transaction.CurrentStep.GetUIPointer(executionContext, transaction);
            }

            if (uiPointer == null)
            {
                // When current step is not a UI step, navigate the process forward which will execute process steps
                // until a UI step is found or the process is blocked by a validation issue.
                var step = transaction.NavigateForward(session);
                if (step.Type.IsUIStep)
                {
                    uiPointer = step.GetUIPointer(executionContext, transaction);
                }
            }

            if (uiPointer == null)
            {
                // At this point something is wrong so navigate the user to the transaction error form.
                uiPointer = new UIPointer
                {
                    UIDefinition = "TransactionError",
                    UIRecordId = transaction.Id,
                    UIRecordType = "ccllc_transaction",
                    UIType = eUIStepTypeEnum.DataForm
                };
            }

            executionContext.Trace("Adding UI Pointer to output parameters.");
            executionContext.OutputParameters["UIPointer"] = uiPointer.Serialize();
        }
    }
}
