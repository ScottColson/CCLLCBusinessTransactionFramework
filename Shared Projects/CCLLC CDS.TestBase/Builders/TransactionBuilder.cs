using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionBuilder : EntityBuilder<ccllc_transaction>
    {
        private ccllc_transaction Proxy { get; set; }

        public TransactionBuilder()
        {
            Proxy = new ccllc_transaction();
        }

        public TransactionBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionBuilder OfTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionBuilder ForCustomer(Id id)
        {
            Proxy.ccllc_CustomerId = id.EntityReference;
            return this;
        }

        public TransactionBuilder UsingContextRecord(Id id)
        {
            Proxy.ccllc_ContextRecordType = id.LogicalName;
            Proxy.ccllc_ContextRecordGUID = id.EntityId.ToString();
            return this;
        }

        public TransactionBuilder UsingProcess(Id id)
        {
            Proxy.ccllc_CurrentProcessId = id.EntityReference;
            Proxy.ccllc_InitiatingProcessId = id.EntityReference;
            return this;
        }

        public TransactionBuilder AtStep(Id id)
        {
            Proxy.ccllc_CurrentStepId = id.EntityReference;
            return this;
        }

        public TransactionBuilder WithAgent(Id id)
        {
            Proxy.ccllc_InitiatingAgentId = id.EntityReference;
            return this;
        }

        public TransactionBuilder WithLocation(Id id)
        {
            Proxy.ccllc_InitiatingLocationId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transaction BuildInternal()
        {
            return Proxy;
        }

    }
}

