namespace CCLLC.BTF.Process
{
    /// <summary>
    /// The results from executing a <see cref="IProcessStep"/>.
    /// </summary>
    public interface IStepExecutionResult
    {
        bool StepIsValid{ get; }
        bool StepIsBlocked { get; }
        IProcessStep NextStep { get; }
    }
}
