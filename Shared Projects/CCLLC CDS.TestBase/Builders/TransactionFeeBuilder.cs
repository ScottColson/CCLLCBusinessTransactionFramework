using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionFeeBuilder : EntityBuilder<ccllc_transactionfee>
    {
        private ccllc_transactionfee Proxy { get; set; }

        public TransactionFeeBuilder()
        {
            Proxy = new ccllc_transactionfee();
        }

        public TransactionFeeBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionFeeBuilder ForTransaction(Id id)
        {
            Proxy.ccllc_TransactionId = id.EntityReference;
            return this;
        }

        public TransactionFeeBuilder WithFee(Id id)
        {
            Proxy.ccllc_FeeId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transactionfee BuildInternal()
        {
            return Proxy;
        }

    }
}

