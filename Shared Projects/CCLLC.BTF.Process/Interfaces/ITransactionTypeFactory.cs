using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface ITransactionTypeFactory
    {
        ITransactionType CreateTransactionType(IProcessExecutionContext executionContext, bool useCache = true);
    }
}
