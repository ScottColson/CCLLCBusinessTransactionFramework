using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionProcessBuilder : EntityBuilder<ccllc_transactionprocess>
    {
        private ccllc_transactionprocess Proxy { get; set; }

        public TransactionProcessBuilder()
        {
            Proxy = new ccllc_transactionprocess();    
        }

        public TransactionProcessBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionProcessBuilder ForTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionProcessBuilder WithInitialStep(Id id)
        {
            Proxy.ccllc_InitialProcessStepId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transactionprocess BuildInternal()
        {
            return Proxy;
        }

    }
}

