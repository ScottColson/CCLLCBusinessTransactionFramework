using System;
using System.Collections.Generic;
using CCLLC.Core;


namespace CCLLC.BTF.Process { 
    public interface ITransactionProcessFactory
    {
        ITransactionProcess CreateTransactionProcess(IProcessExecutionContext executionContext, IRecordPointer<Guid> processId, string name, IRecordPointer<Guid> transactionTypeId, IRecordPointer<Guid> initialStepId, IEnumerable<IProcessStep> processSteps, TimeSpan? cacheTimeout = null);

    }
}
