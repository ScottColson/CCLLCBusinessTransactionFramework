using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionInitialFeeBuilder : EntityBuilder<ccllc_transactioninitialfee>
    {
        private ccllc_transactioninitialfee Proxy { get; set; }

        public TransactionInitialFeeBuilder()
        {
            Proxy = new ccllc_transactioninitialfee();
        }

        public TransactionInitialFeeBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionInitialFeeBuilder ForTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionInitialFeeBuilder WithFee(Id id)
        {
            Proxy.ccllc_FeeId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transactioninitialfee BuildInternal()
        {
            return Proxy;
        }

    }
}
