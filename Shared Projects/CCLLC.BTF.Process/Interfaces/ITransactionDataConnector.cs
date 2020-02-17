using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionDataConnector
    {
        ITransactionRecord GetTransactionRecord(IDataService dataService, IRecordPointer<Guid> recordId);

        ITransactionRecord NewTransactionRecord(IDataService dataService, IRecordPointer<Guid> initiatingAgentId, IRecordPointer<Guid> initiatingLocaitonId, IRecordPointer<Guid> customerId, IRecordPointer<Guid> contextRecordId, IRecordPointer<Guid> transactionTypeId, IRecordPointer<Guid> initiatingProcessId, IRecordPointer<Guid> currentProcessId, IRecordPointer<Guid> currentStepId, string name);

        void UpdateTransactionRecord(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> currentStepId);

        ITransactionDataRecord GetFirstMatchingTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField);


        ITransactionContextRecord GetTransactionContextRecord(IDataService dataService, IRecordPointer<Guid> contextRecordId);

        ITransactionDataRecord NewTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField, string name, IRecordPointer<Guid> customerId);
    }
}
