namespace CCLLC.BTF.Platform
{
    public class LogicEvaluationResult : ILogicEvaluationResult
    {
        public bool Passed { get; }

        public bool HasMessage { get { return !string.IsNullOrEmpty(this.Message); } }

        public string Message { get; }

        public LogicEvaluationResult(bool passed, string message)
        {
            Passed = passed;
            Message = message;
        }
    }
}
