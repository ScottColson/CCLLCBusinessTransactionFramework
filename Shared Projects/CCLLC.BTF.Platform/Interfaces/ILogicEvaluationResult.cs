namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluationResult
    {
        bool Result { get; }
        bool HasMessage { get; }
        string Message { get; }
    }
}
