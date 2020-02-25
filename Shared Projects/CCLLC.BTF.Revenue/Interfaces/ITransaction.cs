using System;

namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core; 

    public interface ITransaction : IRecordPointer<Guid>
    {
        /// <summary>
        /// The effective date for pricing fees associated with the Transaction.
        /// </summary>
        DateTime PricingDate { get; }
    }
}
