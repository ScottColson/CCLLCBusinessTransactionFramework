using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process.StepType
{
    public class Branch : ProcessStepTypeBase
    {
        public Branch(string recordType, Guid id, string name, string implementationAssembly, string implementationClass) : base(recordType, id, name, implementationAssembly, implementationClass)
        {
            base.IsConditional = true;
        }

        public override bool IsReversable => true;

        public override bool IsUIStep => false;

        public override void Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            //No Action
        }

        public override bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters)
        {
            //No Action
            return false;
        }

        public override void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if(parameters.Count > 0) throw new Exception("Branch Step does not support parameters");
        }
            
        public override IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters)
        {
            return null;
        }
    }
}
