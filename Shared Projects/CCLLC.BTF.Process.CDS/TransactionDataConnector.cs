using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;
    using CCLLC.CDS.Sdk;

    public class TransactionDataConnector : ITransactionDataConnector
    {
        public IList<ITransactionGroup> GetAllTransactionGroups(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactiongroup>()
                   .Select("ccllc_transactiongroupid", "ccllc_name", "ccllc_displayrank")
                   .WhereAll(e => e.IsActive())
                   .RetrieveAll().ToList<ITransactionGroup>();
        }

        public IList<ITransactionTypeRecord> GetAllTransactionTypeRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactiontype>()
                   .Select("ccllc_transactiontypeid", "ccllc_name", "ccllc_displayrank", "ccllc_datarecordconfiguration","ccllc_transactiongroupid","ccllc_startupprocessid")
                   .WhereAll(e => e.IsActive())
                   .RetrieveAll().ToList<ITransactionTypeRecord>();
        }

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
                            new OrderExpression("createdon", OrderType.Ascending) //newest first
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

        public IList<IAuthroizedChannelRecord> GetAllTransactionAuthorizedChannels(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactiontypeauthorizedchannel>()
                     .Select("ccllc_channelid", "ccllc_transactiontypeid")
                     .WhereAll(e => e
                         .IsActive()
                         .Attribute("ccllc_channelid").IsNotNull()
                         .Attribute("ccllc_transactiontypeid").IsNotNull())
                     .RetrieveAll().ToList<IAuthroizedChannelRecord>();
        }

        public IList<IAuthroizedRoleRecord> GetAllAuthorizedRoles(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactiontypeauthorizedrole>()
                    .Select("ccllc_roleid", "ccllc_transactiontypeid")
                    .WhereAll(e => e
                        .IsActive()
                        .Attribute("ccllc_roleid").IsNotNull()
                        .Attribute("ccllc_transactiontypeid").IsNotNull())
                    .RetrieveAll().ToList<IAuthroizedRoleRecord>();
        }

        public ITransactionDataRecord NewTransactionDataRecord(IDataService dataService, IRecordPointer<Guid> transactionId, string recordType, string nameField, string transactionField, string customerField, string name, IRecordPointer<Guid> customerId, IDictionary<string,string> defaultValues = null)
        {
            try
            {
                _ = dataService ?? throw new ArgumentNullException("dataService");
                _ = transactionId ?? throw new ArgumentNullException("transactionId");
                _ = recordType ?? throw new ArgumentNullException("recordType");
                _ = nameField ?? throw new ArgumentNullException("nameField");
                _ = transactionField ?? throw new ArgumentNullException("transactionField");
                _ = customerField ?? throw new ArgumentNullException("customerField");

                var orgService = dataService.ToOrgService();

                var record = new Entity(recordType);
                record[nameField] = name;
                record[transactionField] = transactionId.ToEntityReference();
                record[customerField] = customerId.ToEntityReference();

                if (defaultValues != null && defaultValues.Count > 0)
                {
                    var attributes = orgService.GetAttributeMetadataForEntity(recordType);
                    
                    foreach(var key in defaultValues.Keys)
                    {
                        var attributeMetadata = attributes.Where(a => a.LogicalName == key).FirstOrDefault() 
                            ?? throw new Exception(string.Format("{0} is not a valid attribute name for entity {1}",key,recordType));

                        var value = defaultValues[key];

                        record.ParseAndAddAttributeValue(key, value, attributeMetadata);
                    }
                }

                Guid id = orgService.Create(record);
                record = orgService.Retrieve(recordType, id, new ColumnSet(true));

                return new TransactionDataRecord(record, transactionField, customerField);

            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error while creating a new Transaction Data Record.", ex);
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

        public IList<IInitialFeeRecord> GetAllInitialFees(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactioninitialfee>()
                    .Select("ccllc_feeid", "ccllc_transactiontypeid")
                    .WhereAll(e => e
                        .IsActive()
                        .Attribute("ccllc_feeid").IsNotNull()
                        .Attribute("ccllc_transactiontypeid").IsNotNull())
                    .RetrieveAll().ToList<IInitialFeeRecord>();
        }

        public IList<ITransactionContextType> GetAllTransactionContextTypes(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactiontypecontext>()
                    .SelectAll()
                    .WhereAll(e => e
                        .IsActive()
                        .Attribute("ccllc_transactiontypeid").IsNotNull())
                    .RetrieveAll().ToList<ITransactionContextType>();
        }

        public IList<IRequirementRecord> GetAllTransactionRequirements(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactionrequirement>()
                    .SelectAll()
                    .WhereAll(e => e
                        .IsActive()
                        .Attribute("ccllc_evaluatortypeid").IsNotNull()
                        .Attribute("ccllc_transactiontypeid").IsNotNull())
                    .RetrieveAll().ToList<IRequirementRecord>();
        }

        public IList<IRequirementWaiverRole> GetAllRequirementWaiverRoles(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactionrequirementwaiverrole>()
                    .SelectAll()
                    .WhereAll(e => e.IsActive())
                    .RetrieveAll().ToList<IRequirementWaiverRole>();
        }

        public IList<ITransactionProcessRecord> GetAllTransactionProcesses(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_transactionprocess>()
                .SelectAll()
                .WhereAny(e => e.IsActive())
                .RetrieveAll().ToList<ITransactionProcessRecord>();
        }

        public IList<IProcessStepRecord> GetAllProcessSteps(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_processstep>()
                   .SelectAll()
                   .WhereAny(e => e
                        .IsActive()
                        .Attribute("ccllc_processsteptypeid").IsNotNull())
                   .RetrieveAll().ToList<IProcessStepRecord>();
        }

        public IList<IAuthroizedChannelRecord> GetAllStepAuthorizedChannels(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_processstepauthorizedchannel>()
                   .SelectAll()
                   .WhereAny(e => e
                       .IsActive())
                   .RetrieveAll().ToList<IAuthroizedChannelRecord>();
        }

        public IList<IProcessStepTypeRecord> GetAllStepTypes(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_processsteptype>()
                .SelectAll()
                .WhereAny(e => e.IsActive())
                .RetrieveAll().ToList<IProcessStepTypeRecord>();

        }

        public IList<IStepRequirement> GetAllStepRequirements(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_processsteprequirement>()
                    .SelectAll()
                    .WhereAny(e => e
                        .IsActive())
                    .RetrieveAll().ToList<IStepRequirement>();
        }

        public IList<IAlternateBranchRecord> GetAlternateBranches(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_alternatebranch>()
                    .SelectAll()
                    .WhereAny(e => e
                        .IsActive())
                    .RetrieveAll().ToList<IAlternateBranchRecord>();
        }

        public IList<IRequirementDeficiencyRecord> GetDeficiencyRecords(IDataService dataService, IRecordPointer<Guid> transactionId)
        {
            _ = transactionId ?? throw new ArgumentNullException("transactionId");

            return dataService.ToOrgService().Query<ccllc_transactiondeficiency>()
                .SelectAll()
                .WhereAny(e => e
                    .IsActive()
                    .Attribute("ccllc_transactionid").IsEqualTo(transactionId.Id))
                .RetrieveAll().ToList<IRequirementDeficiencyRecord>();
        }

        public IRequirementDeficiencyRecord CreateDeficiencyRecord(IDataService dataService, string name, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> requirementId)
        {
            var record = new ccllc_transactiondeficiency
            {
                ccllc_name = name,
                ccllc_TransactionId = transactionId?.ToEntityReference(),
                ccllc_TransactionRequirementId = requirementId?.ToEntityReference(),
                statuscode = ccllc_transactiondeficiency_statuscode.Active
            };

            record.Id = dataService.ToOrgService().Create(record);

            return record;
        }

        public void UpdateDeficiencyRecordStatus(IDataService dataService, IRecordPointer<Guid> deficiencyId, eDeficiencyStatusEnum status)
        {
            ccllc_transactiondeficiency_statuscode statusCode = ccllc_transactiondeficiency_statuscode.Active;
            ccllc_transactiondeficiencyState stateCode = ccllc_transactiondeficiencyState.Active;

            switch (status)
            {
                case eDeficiencyStatusEnum.Cleared:
                    stateCode = ccllc_transactiondeficiencyState.Inactive;
                    statusCode = ccllc_transactiondeficiency_statuscode.Cleared;
                    break;
                case eDeficiencyStatusEnum.Waived:
                    stateCode = ccllc_transactiondeficiencyState.Active;
                    statusCode = ccllc_transactiondeficiency_statuscode.Waived;
                    break;
            }

            var record = new ccllc_transactiondeficiency
            {
                Id = deficiencyId.Id,
                statecode = stateCode,
                statuscode = statusCode
            };

            dataService.ToOrgService().Update(record);

        }

    }
}
