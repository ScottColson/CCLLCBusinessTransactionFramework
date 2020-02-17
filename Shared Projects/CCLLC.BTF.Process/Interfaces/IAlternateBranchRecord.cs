using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IAlternateBranchRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        int EvaluationOrder { get; }
        IRecordPointer<Guid> ParentStepId { get; }
        IRecordPointer<Guid> SubsequentStepId { get; }
        IRecordPointer<Guid> EvaluatorTypeId { get; }
        string EvaluationParameters { get; }       
    }
}
