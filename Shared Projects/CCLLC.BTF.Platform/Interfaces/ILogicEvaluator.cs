using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluator
    {
        ILogicEvaluatorType Type { get; }
        ISerializedParameters Parameters { get; }

        ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ITransaction transaction);
    }
}
