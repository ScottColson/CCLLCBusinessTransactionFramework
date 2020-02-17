using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface ITransactionContextFactory
    {
        ITransactionContext CreateTransactionContext(IProcessExecutionContext executionContext, IRecordPointer<Guid> transactionContextId, TimeSpan? cacheTimeout = null);        
    }
}
