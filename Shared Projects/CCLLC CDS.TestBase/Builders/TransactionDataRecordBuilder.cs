using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionDataRecordBuilder : EntityBuilder<new_transactiondatarecord>
    {
        private new_transactiondatarecord Proxy { get; set; }

        public TransactionDataRecordBuilder()
        {
            Proxy = new new_transactiondatarecord();
        }

        public TransactionDataRecordBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods
        
        public TransactionDataRecordBuilder ForTransaction(Id id)
        {
            Proxy.new_TransactionId = id.EntityReference;
            return this;
        }

        public TransactionDataRecordBuilder ForCustomer(Id id)
        {
            Proxy.new_CustomerId = id.EntityReference;
            return this;
        }

        public TransactionDataRecordBuilder WithFieldSetTo(string fieldName, object fieldValue)
        {
            Proxy[fieldName] = fieldValue;
            return this;
        }

        #endregion

        protected override new_transactiondatarecord BuildInternal()
        {
            return Proxy;
        }

    }
}

