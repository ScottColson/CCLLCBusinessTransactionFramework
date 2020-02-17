using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface IRequirementEvaluator
    {
        IList<IRequirementDeficiency> Evaluate(IProcessExecutionContext executionContext, IList<IRecordPointer<Guid>> requirementPointers);
    }
}
