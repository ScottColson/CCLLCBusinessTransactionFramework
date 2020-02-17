using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;

    public class TransactionDataConnector : ITransactionDataConnector
    {
        public ITransactionDataRecord GetFirstMatchingTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField)
        {
            try
            {
                if (dataService is null) throw new ArgumentNullException("dataService");
                if (transactionId is null) throw new ArgumentNullException("transactionId");
                if (recordType is null) throw new ArgumentNullException("recordType");
                if (nameField is null) throw new ArgumentNullException("nameField");
                if (transactionField is null) throw new ArgumentNullException("transactionField");
                if (customerField is null) throw new ArgumentNullException("customerField");                               

                var transactionDataRecords = dataService.ToOrgService().RetrieveMultiple(
                        new QueryExpression
                        {
                            EntityName = recordType,
                            NoLock = true,
                            ColumnSet = new ColumnSet(true),
                            Criteria = new FilterExpression
                            {
                                Conditions =
                                {
                                new ConditionExpression(transactionField, ConditionOperator.Equal, transactionId.Id),
                                new ConditionExpression("statecode",ConditionOperator.Equal,0)
                                }
                            },
                            Orders =
                            {
                            new OrderExpression("createdon", OrderType.Ascending) //newest firsit
                            }
                        });

               
                if(transactionDataRecords.Entities.Count > 0)
                {
                    var firstRecord = transactionDataRecords.Entities[0];
                    return new TransactionDataRecord(firstRecord, transactionField, customerField);
                }

                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ITransactionContextRecord GetTransactionContextRecord(IDataService dataService, IRecordPointer<Guid> contextRecordId)
        {
            IOrganizationService orgService = dataService.ToOrgService();

            Entity record = null;
            string name = null;
            EntityReference customerId = null;
            int statusCode;

            if (contextRecordId.RecordType == "contact")
            {
                record = orgService.Retrieve("contact", contextRecordId.Id, new ColumnSet("fullname", "statuscode"));
                name = record.GetAttributeValue<string>("fullname");
                statusCode = record.GetAttributeValue<OptionSetValue>("statuscode")?.Value ?? -1;
                customerId = record.ToEntityReference();
                return new TransactionContextRecord("contact", contextRecordId.Id, name, customerId?.ToRecordPointer(), statusCode);

            }

            if (contextRecordId.RecordType == "account")
            {
                record = orgService.Retrieve("account", contextRecordId.Id, new ColumnSet("name", "statuscode"));
                name = record.GetAttributeValue<string>("name");
                statusCode = record.GetAttributeValue<OptionSetValue>("statuscode")?.Value ?? -1;
                customerId = record.ToEntityReference();
                return new TransactionContextRecord("account", contextRecordId.Id, name, customerId?.ToRecordPointer(), statusCode);
            }

            //Retrieve record using supported convention for entity name and customer id fields.
            string entityPrefix = contextRecordId.RecordType.Split('_')[0];
            string nameField = string.Format("{0}_name", entityPrefix);
            string customerField = string.Format("{0}_customerid", entityPrefix);

            record = orgService.Retrieve(contextRecordId.RecordType, contextRecordId.Id, new ColumnSet(nameField, customerField, "statuscode"));
            name = record.GetAttributeValue<string>("ccllc_name");
            statusCode = record.GetAttributeValue<OptionSetValue>("statuscode")?.Value ?? -1;
            customerId = record.GetAttributeValue<EntityReference>("ccllc_customerid");
            return new TransactionContextRecord(contextRecordId.RecordType, contextRecordId.Id, name, customerId?.ToRecordPointer(), statusCode);

        }

        public ITransactionRecord GetTransactionRecord(IDataService dataService, IRecordPointer<Guid> recordId)
        {
            return dataService.ToOrgService().Retrieve(ccllc_transaction.EntityLogicalName, recordId.Id, new ColumnSet(true)).ToEntity<ccllc_transaction>();

        }

        public ITransactionDataRecord NewTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField, string name, IRecordPointer<Guid> customerId)
        {
            try
            {
                if (dataService is null) throw new ArgumentNullException("dataService");
                if (transactionId is null) throw new ArgumentNullException("transactionId");
                if (recordType is null) throw new ArgumentNullException("recordType");
                if (nameField is null) throw new ArgumentNullException("nameField");
                if (transactionField is null) throw new ArgumentNullException("transactionField");
                if (customerField is null) throw new ArgumentNullException("customerField");


                var record = new Entity(recordType);
                record[nameField] = name;
                record[transactionField] = transactionId.ToEntityReference();
                record[customerField] = customerId.ToEntityReference();

                Guid id = dataService.ToOrgService().Create(record);
                record = dataService.ToOrgService().Retrieve(recordType, id, new ColumnSet(true));

                return new TransactionDataRecord(record, transactionField, customerField);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ITransactionRecord NewTransactionRecord(IDataService dataService, IRecordPointer<Guid> initiatingAgentId, IRecordPointer<Guid> initiatingLocaitonId, IRecordPointer<Guid> customerId, IRecordPointer<Guid> contextRecordId, IRecordPointer<Guid> transactionTypeId, IRecordPointer<Guid> initiatingProcessId, IRecordPointer<Guid> currentProcessId, IRecordPointer<Guid> currentStepId, string name)
        {
            ccllc_transaction transaction = new ccllc_transaction
            {
                ccllc_InitiatingAgentId = initiatingAgentId?.ToEntityReference(),
                ccllc_InitiatingLocationId = initiatingLocaitonId?.ToEntityReference(),
                ccllc_CustomerId = customerId?.ToEntityReference(),
                ccllc_ContextRecordType = contextRecordId?.RecordType,
                ccllc_ContextRecordGUID = contextRecordId?.Id.ToString(),
                ccllc_TransactionTypeId = transactionTypeId?.ToEntityReference(),
                ccllc_InitiatingProcessId = initiatingProcessId?.ToEntityReference(),
                ccllc_CurrentProcessId = currentProcessId?.ToEntityReference(),
                ccllc_CurrentStepId = currentStepId?.ToEntityReference(),
                ccllc_name = name
            };

            transaction.Id = dataService.ToOrgService().Create(transaction);

            return transaction;
        }

        public void UpdateTransactionRecord(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> currentStepId)
        {
            try
            {
                if (dataService is null) throw new ArgumentNullException("dataService");
                if (transactionId is null) throw new ArgumentNullException("transactionId");
                if (currentStepId is null) throw new ArgumentNullException("currentStepId");

                var entity = new ccllc_transaction
                {
                    Id = transactionId.Id,
                    ccllc_CurrentStepId = new EntityReference(ccllc_processstep.EntityLogicalName, currentStepId.Id)
                };

                dataService.ToOrgService().Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
