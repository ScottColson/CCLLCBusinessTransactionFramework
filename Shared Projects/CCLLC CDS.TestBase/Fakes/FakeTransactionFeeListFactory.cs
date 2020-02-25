using System;
using CCLLC.BTF.Revenue;
using CCLLC.Core;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeTransactionFeeListFactory : ITransactionFeeListFactory
    {
        public ITransactionFeeList CreateFeeList(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
