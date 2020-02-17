using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public class TransactionDataRecord : Entity, ITransactionDataRecord
    {
        string CustomerFieldName;
        string TransactionFieldName;

        public TransactionDataRecord(Entity sourceEntity, string transactionFieldName, string customerFieldName) : base(sourceEntity.LogicalName, sourceEntity.Id)
        {
            CustomerFieldName = customerFieldName;
            TransactionFieldName = transactionFieldName;

            try
            {
                foreach (var a in sourceEntity.Attributes)
                {
                    base[a.Key] = a.Value;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IRecordPointer<Guid> TransactionId
        {
            get
            {
                var transactionId = this.GetAttributeValue<EntityReference>(TransactionFieldName);
                if (transactionId == null) throw TransactionException.BuildException(TransactionException.ErrorCode.DataRecordMissingTransactionId);

                return transactionId.ToRecordPointer();
            }
        }

        public IRecordPointer<Guid> CustomerId
        {
            get
            {
                var customerId = this.GetAttributeValue<EntityReference>(CustomerFieldName);
                if (customerId == null) throw TransactionException.BuildException(TransactionException.ErrorCode.DataRecordMissingCustomerId);

                return customerId.ToRecordPointer();
            }
        }

        public string RecordType => this.LogicalName;   

    }
}
