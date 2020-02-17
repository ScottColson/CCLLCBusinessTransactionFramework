using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionRequirementRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        eTransactionRequirementTypeFlags? TypeFlag { get; }
        IRecordPointer<Guid> TransactionTypeId { get; }
        IRecordPointer<Guid> EvaluatorTypeId { get; }
        string RequirementParameters { get; }
    }
}
