using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface ITransactionRequirementFactory
    {
        ITransactionRequirement CreateRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, TimeSpan? cacheTimeout = null);

        ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eTransactionRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, TimeSpan? cacheTimeout = null);

        ITransactionRequirement CreateRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, TimeSpan? cacheTimeout = null);

        ITransactionRequirement CreateEvidenceRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, TimeSpan? cacheTimeout = null);
    }
}
