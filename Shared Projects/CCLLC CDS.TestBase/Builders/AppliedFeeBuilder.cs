using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class AppliedFeeBuilder : EntityBuilder<ccllc_appliedfee>
    {
        private ccllc_appliedfee Proxy { get; set; }

        public AppliedFeeBuilder()
        {
            Proxy = new ccllc_appliedfee();
        }

        public AppliedFeeBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public AppliedFeeBuilder ForTransaction(Id id)
        {
            Proxy.ccllc_TransactionId = id.EntityReference;
            return this;
        }

        public AppliedFeeBuilder WithFee(Id id)
        {
            Proxy.ccllc_FeeId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_appliedfee BuildInternal()
        {
            return Proxy;
        }

    }
}

