using System;
using Microsoft.Xrm.Sdk;
using CCLLC.CDS.Sdk;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process.CDS.Plugins
{
    [CrmPluginRegistration("ccllc_BTF_CanNavigateBackward", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_CanNavigateBackward Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_CanNavigateBackward",
        Id = "{7C4ED1EA-DE69-45A8-A4C0-D5B1D48A7472}")]
    [CrmPluginRegistration("ccllc_BTF_CanNavigateForward", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_CanNavigateForward Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_CanNavigateForward", 
        Id = "{25E49380-E3E7-4532-A5E1-453A2D419CC8}")]
    [CrmPluginRegistration("ccllc_BTF_NavigateBackward", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_NavigateBackward Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_NavigateBackward",
        Id = "{2C0A76D1-0017-4CE1-AB99-7333EDDDDD4B}")]
    [CrmPluginRegistration("ccllc_BTF_NavigateForward", "none", StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        "", "ccllc_BTF_NavigateForward Action Handler", 1001, IsolationModeEnum.Sandbox, Description = "Handle Action call to ccllc_BTF_NavigateForward", 
        Id = "{41B24A47-70C0-4C39-BC8B-65792269361C}")]
    public class ProcessNavigationActionHandlers : PluginBase
    {
        public ProcessNavigationActionHandlers(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig)
        {
            RegisterEventHandler(null, "ccllc_BTF_CanNavigateBackward", ePluginStage.PostOperation, CanNavigateBackwardHandler, "CanNavigateBackwardHandler");
            RegisterEventHandler(null, "ccllc_BTF_CanNavigateForward", ePluginStage.PostOperation, CanNavigateForwardHandler, "CanNavigateForwardHandler");
            RegisterEventHandler(null, "ccllc_BTF_NavigateBackward", ePluginStage.PostOperation, NavigateBackwardHandler, "NavigateBackwardHandler");
            RegisterEventHandler(null, "ccllc_BTF_NavigateForward", ePluginStage.PostOperation, NavigateForwardHandler, "NavigateForwardHandler");
        }

        internal void CanNavigateBackwardHandler(ICDSPluginExecutionContext executionContext)
        {          
            var req = executionContext.CreateOrganizationRequest<ccllc_BTF_CanNavigateBackwardRequest>();

            EntityReference transactionId = req.Target ?? throw new NullReferenceException("Target cannot be null");           
            EntityReference userId = req.UserId ?? new EntityReference("systemuser", executionContext.InitiatingUserId);
                                   
            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();
            var session = platformManager.GenerateSession(executionContext, systemUser, Settings.GenerateSessionCacheTimeout);            

            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext, Settings.BuildTransactionManagerCacheTimout);

            var transaction = manager.LoadTransaction(executionContext, transactionId.ToRecordPointer());

            bool canNavigate = transaction.CanNavigateBackward(session);

            executionContext.OutputParameters["IsAllowed"] = canNavigate;
        }

        internal void CanNavigateForwardHandler(ICDSPluginExecutionContext executionContext)
        {
            var req = executionContext.CreateOrganizationRequest<ccllc_BTF_CanNavigateForwardRequest>();

            EntityReference transactionId = req.Target ?? throw new NullReferenceException("Target cannot be null");
            EntityReference userId = req.UserId ?? new EntityReference("systemuser", executionContext.InitiatingUserId);

            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();
            var session = platformManager.GenerateSession(executionContext, systemUser, Settings.GenerateSessionCacheTimeout);

            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext, Settings.BuildTransactionManagerCacheTimout);

            var transaction = manager.LoadTransaction(executionContext, transactionId.ToRecordPointer());

            bool canNavigate = transaction.CanNavigateForward(session);

            executionContext.OutputParameters["IsAllowed"] = canNavigate;
        }

        internal void NavigateBackwardHandler(ICDSPluginExecutionContext executionContext)
        {
            var req = executionContext.CreateOrganizationRequest<ccllc_BTF_NavigateBackwardRequest>();

            EntityReference transactionId = req.Target ?? throw new NullReferenceException("Target cannot be null");
            EntityReference userId = req.UserId ?? new EntityReference("systemuser", executionContext.InitiatingUserId);
                     
            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();
            var session = platformManager.GenerateSession(executionContext, systemUser, Settings.GenerateSessionCacheTimeout);

            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext, Settings.BuildTransactionManagerCacheTimout);

            var transaction = manager.LoadTransaction(executionContext, transactionId.ToRecordPointer());

            IUIPointer uiPointer = null;
            var step = transaction.NavigateBackward(session);
            if (step.Type.IsUIStep)
            {
                uiPointer = step.GetUIPointer(executionContext, transaction);
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

            executionContext.OutputParameters["UIPointer"] = uiPointer.Serialize();
        }

        internal void NavigateForwardHandler(ICDSPluginExecutionContext executionContext)
        {
            var req = executionContext.CreateOrganizationRequest<ccllc_BTF_NavigateForwardRequest>();

            EntityReference transactionId = req.Target ?? throw new NullReferenceException("Target cannot be null");
            EntityReference userId = req.UserId ?? new EntityReference("systemuser", executionContext.InitiatingUserId);
          
            var systemUser = new SystemUser(userId.LogicalName, userId.Id, userId.Name);

            var platformManager = Container.Resolve<IPlatformManager>();
            var session = platformManager.GenerateSession(executionContext, systemUser, Settings.GenerateSessionCacheTimeout);

            var managerFactory = Container.Resolve<ITransactionManagerFactory>();
            var manager = managerFactory.CreateTransactionManager(executionContext, Settings.BuildTransactionManagerCacheTimout);

            var transaction = manager.LoadTransaction(executionContext, transactionId.ToRecordPointer());

            IUIPointer uiPointer = null;
            var step = transaction.NavigateForward(session);
            if (step.Type.IsUIStep)
            {
                uiPointer = step.GetUIPointer(executionContext, transaction);
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

            executionContext.OutputParameters["UIPointer"] = uiPointer.Serialize();
        }

    }
}
