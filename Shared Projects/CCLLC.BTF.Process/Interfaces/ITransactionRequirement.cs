using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface ITransactionRequirement : IRecordPointer<Guid>
    {       
        string Name { get; }
        eTransactionRequirementTypeFlags TypeFlag { get; }
        IRecordPointer<Guid> TransactionTypeId { get;  }
        ILogicEvaluator Evaluator { get; }
        IReadOnlyList<IRecordPointer<Guid>> AuthorizedWaiverRoles { get; }

        bool IsAuthorizedToWaive(IAgent agent);
    }
}
