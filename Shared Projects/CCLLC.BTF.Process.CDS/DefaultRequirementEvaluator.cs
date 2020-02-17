using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public class DefaultRequirementEvaluator : IRequirementEvaluator
    {
        public IList<IRequirementDeficiency> Evaluate(IProcessExecutionContext executionContext, IList<IRecordPointer<Guid>> requirementPointers)
        {
            executionContext.TrackException(new Exception("Evalautor is not implemented."));
            return new List<IRequirementDeficiency>();
        }
    }
}
