using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionTypeContextBuilder : EntityBuilder<ccllc_transactiontypecontext>
    {
        private ccllc_transactiontypecontext Proxy { get; set; }

        public TransactionTypeContextBuilder()
        {
            Proxy = new ccllc_transactiontypecontext();
        }

        public TransactionTypeContextBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionTypeContextBuilder ForTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionTypeContextBuilder WithEntityType(string entityLogicalName)
        {
            Proxy.ccllc_name = entityLogicalName;
            return this;
        }

        #endregion

        protected override ccllc_transactiontypecontext BuildInternal()
        {
            return Proxy;
        }

    }
}
