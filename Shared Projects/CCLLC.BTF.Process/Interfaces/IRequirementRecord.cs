using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IRequirementRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        eRequirementTypeFlags? TypeFlag { get; }
        IRecordPointer<Guid> TransactionTypeId { get; }
        IRecordPointer<Guid> EvaluatorTypeId { get; }
        string RequirementParameters { get; }
    }
}
