using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface ITransactionHistoryFactory
    {
        ITransactionHistory CreateTransactionHistory(IProcessExecutionContext executionContext, ITransaction transaction);

    }
}
