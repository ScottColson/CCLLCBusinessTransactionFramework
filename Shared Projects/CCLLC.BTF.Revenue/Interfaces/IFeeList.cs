using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    /// <summary>
    /// A cached list of defined revenue fees. 
    /// </summary>
    public interface IFeeList
    {
        IFee GetFee(IProcessExecutionContext executionContext,  IRecordPointer<Guid> feeId, bool useCache = true);

        IFee GetFee(IProcessExecutionContext executionContext, string referenceNumber, bool useCache = true);
    }
}
