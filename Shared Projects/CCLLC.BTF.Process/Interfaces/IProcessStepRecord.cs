using System;


namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IProcessStepRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        IRecordPointer<Guid> TransactionProcessId { get; }
        IRecordPointer<Guid> ProcessStepTypeId { get; }
        IRecordPointer<Guid> SubsequentStepId { get; }
        string StepParameters { get; }
    }
}
