using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionDeficienciesFactory
    {
        ITransactionDeficiencies CreateTransactionDeficiencies(IProcessExecutionContext executionContext, ITransaction transaction);
        
    }
}
