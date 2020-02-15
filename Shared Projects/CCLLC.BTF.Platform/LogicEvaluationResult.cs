namespace CCLLC.BTF.Platform
{
    public class LogicEvaluationResult : ILogicEvaluationResult
    {
        public bool Result { get; }

        public bool HasMessage { get { return !string.IsNullOrEmpty(this.Message); } }

        public string Message { get; }

        public LogicEvaluationResult(bool result, string message)
        {
            Result = result;
            Message = message;
        }
    }
}
