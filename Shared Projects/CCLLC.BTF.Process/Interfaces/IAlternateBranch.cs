using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface IAlternateBranch : IRecordPointer<Guid>
    {       
        string Name { get; }
        int EvaluationOrder { get; }
        IRecordPointer<Guid> ParentStepPointer { get; }       
        IRecordPointer<Guid> SubsequentStepPointer { get; }
        ILogicEvaluatorType Type { get; }
        ISerializedParameters Parameters { get; }
        ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ITransaction transaction);
    }
}
