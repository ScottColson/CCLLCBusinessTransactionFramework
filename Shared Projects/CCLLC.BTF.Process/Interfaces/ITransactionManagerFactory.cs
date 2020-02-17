using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionManagerFactory
    {
        ITransactionManager CreateTransactionManager(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout = null);
    }
}
