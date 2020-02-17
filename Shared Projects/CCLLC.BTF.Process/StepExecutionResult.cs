namespace CCLLC.BTF.Process
{
    public class StepExecutionResult : IStepExecutionResult
    {
        public bool StepIsValid { get; set; }

        public bool StepIsBlocked { get; set; }

        public IProcessStep NextStep { get; set; }

    }
}
