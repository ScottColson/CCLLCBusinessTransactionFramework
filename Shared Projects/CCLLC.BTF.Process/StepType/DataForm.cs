using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process.StepType
{
    public class DataForm : ProcessStepTypeBase
    {
        public DataForm(string recordType, Guid id, string name, string implementationAssembly, string implementationClass) 
            : base(recordType, id, name, implementationAssembly, implementationClass)
        {
        }

        public override bool IsReversable => false;

        public override bool IsUIStep => true;

        public override void Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            //No action.
        }

        public override IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters)
        {
            try
            {
                var dataRecord = transaction.DataRecord;
                executionContext.Trace("Creating UI Pointer for retrieved data record.");                
               
                return new UIPointer
                {
                    UIType = eUIStepTypeEnum.DataForm,
                    UIRecordType = dataRecord.RecordType,
                    UIRecordId = dataRecord.Id,
                    UIDefinition = parameters["FormId"]
                };

            }
            catch(Exception ex){
                throw new Exception(ex.Message, ex);
            }
        }

        public override bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            // No action.
            return false;
        }

        public override void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey("FormId") || string.IsNullOrEmpty(parameters["FormId"])) throw new Exception("Entity Data Capture step requires parameter 'FormId'");
        }
    }
}
