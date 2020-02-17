using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface IAlternateBranchFactory
    {
        IAlternateBranch CreateAlternateBranch(IProcessExecutionContext executionContext, IRecordPointer<Guid> alternateBranchId, string name, 
            int evaluationOrder, IRecordPointer<Guid> parentStepId, IRecordPointer<Guid> subsequentStepId, IRecordPointer<Guid> evaluatorTypeId, 
            string parameters, TimeSpan? cacheTimeout = null);
       
    }
}
