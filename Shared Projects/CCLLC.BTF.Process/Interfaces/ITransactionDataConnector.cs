using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionDataConnector
    {
        IList<IAuthroizedChannelRecord> GetAllTransactionAuthorizedChannels(IDataService dataService);

        IList<IAuthroizedChannelRecord> GetAllStepAuthorizedChannels(IDataService dataService);

        IList<IAuthroizedRoleRecord> GetAllAuthorizedRoles(IDataService dataService);

        IList<IInitialFeeRecord> GetAllInitialFees(IDataService dataService);

        IList<ITransactionContextType> GetAllTransactionContextTypes(IDataService dataService);

        IList<ITransactionGroup> GetAllTransactionGroups(IDataService dataService);

        IList<IRequirementRecord> GetAllTransactionRequirements(IDataService dataService);

        IList<IRequirementWaiverRole> GetAllRequirementWaiverRoles(IDataService dataService);

        IList<ITransactionTypeRecord> GetAllTransactionTypeRecords(IDataService dataService);

        IList<IProcessStepRecord> GetAllProcessSteps(IDataService dataService);

        IList<ITransactionProcessRecord> GetAllTransactionProcesses(IDataService dataService);

        ITransactionRecord GetTransactionRecord(IDataService dataService, IRecordPointer<Guid> recordId);

        ITransactionRecord NewTransactionRecord(IDataService dataService, IRecordPointer<Guid> initiatingAgentId, IRecordPointer<Guid> initiatingLocaitonId, IRecordPointer<Guid> customerId, IRecordPointer<Guid> contextRecordId, IRecordPointer<Guid> transactionTypeId, IRecordPointer<Guid> initiatingProcessId, IRecordPointer<Guid> currentProcessId, IRecordPointer<Guid> currentStepId, string name);

        void UpdateTransactionRecord(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> currentStepId);

        ITransactionDataRecord GetFirstMatchingTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField);


        ITransactionContextRecord GetTransactionContextRecord(IDataService dataService, IRecordPointer<Guid> contextRecordId);

        ITransactionDataRecord NewTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField, string name, IRecordPointer<Guid> customerId, IDictionary<string,string> defaultValues = null);

        IList<IProcessStepTypeRecord> GetAllStepTypes(IDataService dataService);

        IList<IStepRequirement> GetAllStepRequirements(IDataService dataService);

        IList<IAlternateBranchRecord> GetAlternateBranches(IDataService dataService);

        IList<IRequirementDeficiencyRecord> GetDeficiencyRecords(IDataService dataService, IRecordPointer<Guid> transactionId);

        IRequirementDeficiencyRecord CreateDeficiencyRecord(IDataService dataService, string name, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> requirementId);

        void UpdateDeficiencyRecordStatus(IDataService dataService, IRecordPointer<Guid> deficiencyId, eDeficiencyStatusEnum status);
    }
}
