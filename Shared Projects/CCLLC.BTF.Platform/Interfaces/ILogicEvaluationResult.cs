namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluationResult
    {
        bool Passed { get; }
        bool HasMessage { get; }
        string Message { get; }
    }
}
