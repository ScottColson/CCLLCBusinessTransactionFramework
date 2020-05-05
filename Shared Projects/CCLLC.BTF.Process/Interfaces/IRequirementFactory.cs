using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public interface IRequirementFactory
    {
        IRequirement CreateRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, bool useCache = true);

        IRequirement CreateEvidenceRequirement(IProcessExecutionContext executionContext, IRecordPointer<Guid> requirementId, string name, eRequirementTypeFlags? requirementType, IRecordPointer<Guid> transactionTypeId, ILogicEvaluatorType evaluatorType, string parameters, IEnumerable<IRecordPointer<Guid>> waiverRoles, bool useCache = true);

        IRequirement CreateRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, bool useCache = true);

        IRequirement CreateEvidenceRequirement(IProcessExecutionContext executionCOntext, IRecordPointer<Guid> requirementId, string parameters, bool useCache = true);
    }
}
