using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Process.StepType;

namespace CCLLC.BTF.Process.CDS.StepType
{
    /// <summary>
    /// Executes an action bound to the context data record associated with a transaction. The action name and any 
    /// optional action arguments are specified in the process step parameters.
    /// </summary>
    public class ContextRecordAction : ProcessStepTypeBase
    {
        public ContextRecordAction(IRecordPointer<Guid> transactionContextId, string name, string implementationAssembly, string implementationClass) 
            : base(transactionContextId.RecordType,transactionContextId.Id, name, implementationAssembly, implementationClass)
        {
        }

        public override bool IsReversable => false;

        public override bool IsUIStep => false;

        public override bool IsConditional => false;

        public override void Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            try
            {
                if (!parameters.ContainsKey("ActionName")) throw new Exception("ContextRecordAction requires a parameter for ActionName");

                var contextRecord = transaction.TransactionContext;
                var dataRecord = transaction.DataRecord;
               
                var req = new OrganizationRequest(parameters["ActionName"]);
                req["Target"] = new EntityReference(contextRecord.RecordType, contextRecord.Id);
                req["Transaction"] = transaction.ToEntityReference();
                req["DataRecord"] = new EntityReference(dataRecord.RecordType, dataRecord.Id);
                
                //process any additional parameter data passed in from the configuration.
                if(parameters.Count > 1)
                {
                    foreach (var key in parameters.Keys)
                    {
                        if (key != "ActionName" && !string.IsNullOrEmpty(parameters[key]))
                        {
                            req[key] = parameters[key];
                        }
                    }
                }

                executionContext.DataService.ToOrgService().Execute(req);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public override IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters)
        {
            return null;
        }

        public override bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            //No action
            return false;
        }

        public override void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey("ActionName") || string.IsNullOrEmpty(parameters["ActionName"]))
            {
                throw new Exception("ContextRecordAction requires a parameter for ActionName.");
            }
        }
    }
}
