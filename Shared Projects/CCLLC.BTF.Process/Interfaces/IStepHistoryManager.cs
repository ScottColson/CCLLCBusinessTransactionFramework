using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface IStepHistoryManager
    {
        ITransactionHistory CreateTransactionHistory(IProcessExecutionContext executionContext, ITransaction transaction);

    }
}
