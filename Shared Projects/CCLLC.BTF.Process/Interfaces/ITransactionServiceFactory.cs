using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionServiceFactory
    {
        ITransactionService CreateTransactionService(IProcessExecutionContext executionContext, bool useCache = true);
    }
}
