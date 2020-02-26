using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface IProcessStepType : IDeferredImplementation
    {
        bool IsConditional { get; set; }
        bool IsReversable { get; }
        bool IsUIStep { get; }
       
        void Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters);

        bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, ISerializedParameters parameters);

        void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters);

        IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters);
       
    }
}
