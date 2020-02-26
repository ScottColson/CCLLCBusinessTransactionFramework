using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transaction : ITransactionRecord
    {
        public IRecordPointer<Guid> TransactionTypeId => this.ccllc_TransactionTypeId?.ToRecordPointer();

        public IRecordPointer<Guid> ContextRecordId
        {
            get {

                var recordType = this.ccllc_ContextRecordType ?? throw new Exception("Missing context record type.");
                var recordId = this.ccllc_ContextRecordGUID ?? throw new Exception("Missing context record id.");

                Guid parsedId;
                if (!Guid.TryParse(recordId, out parsedId)) throw new Exception("Invalid context record id.");

                return new RecordPointer<Guid>(recordType, parsedId);
            }
        }

        public string Name => this.ccllc_name;

        public string ReferenceNumber => this.ccllc_ReferenceNumber;

        public DateTime? PricingDate => null; //throw new NotImplementedException();

        public IRecordPointer<Guid> InitiatingProcessId => this.ccllc_InitiatingProcessId?.ToRecordPointer();

        public IRecordPointer<Guid> CurrentProcessId => this.ccllc_CurrentProcessId?.ToRecordPointer();

        public IRecordPointer<Guid> CurrentStepId => this.ccllc_CurrentStepId?.ToRecordPointer();

        public IRecordPointer<Guid> CustomerId => this.ccllc_CustomerId?.ToRecordPointer();

        public IRecordPointer<Guid> InitiatingAgentId => this.ccllc_InitiatingAgentId?.ToRecordPointer();

        public IRecordPointer<Guid> InitiatingLocationId => this.ccllc_InitiatingLocationId?.ToRecordPointer();

        public string RecordType => this.LogicalName;
    }
}
