using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.CDS.Sdk;

namespace CCLLC.BTF.Platform.CDS
{    
    using CCLLC.Core;

    public class PlatformDataConnector : IPlatformDataConnector
    {
        public PlatformDataConnector() 
        {
        }

        public IList<IRecordPointer<Guid>> GetAgentAuthorizedCustomers(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Query<ccllc_agentauthorizedcustomer>()
                .Select("ccllc_customerid")
                .WhereAll(e => e
                    .IsActive()
                    .Attribute("ccllc_agentid").IsEqualTo(agentId.Id)
                    .Attribute("ccllc_customerid").IsNotNull())
                .RetrieveAll().Select(r => r.ccllc_CustomerId.ToRecordPointer()).ToList();
        }

        public IList<IRecordPointer<Guid>> GetAgentProhibitedCustomers(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Query<ccllc_agentprohibitedcustomer>()
                .Select("ccllc_customerid")
                .WhereAll(e => e
                    .IsActive()
                    .Attribute("ccllc_agentid").IsEqualTo(agentId.Id)
                    .Attribute("ccllc_customerid").IsNotNull())
                .RetrieveAll().Select(r => r.ccllc_CustomerId.ToRecordPointer()).ToList();
        }

        public IAgentRecord GetAgentRecord(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Retrieve(agentId.RecordType, agentId.Id, new ColumnSet(true)).ToEntity<ccllc_agent>();
        }

        public IList<IRole> GetAgentRoles(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Query<ccllc_role>()
                .Select("ccllc_roleid", "ccllc_name")
                .WhereAll(e => e
                    .IsActive())
                .InnerJoin<ccllc_agentrole>("ccllc_roleid","ccllc_roleid", r => r
                    .WhereAll(ar => ar
                        .Attribute("ccllc_agentid").IsEqualTo(agentId.Id)))
                .RetrieveAll().ToList<IRole>();           
        }


        public IList<IChannelRecord> GetChannelRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_channel>()
                .SelectAll()
                .WhereAll(e => e.IsActive())
                .RetrieveAll().ToList<IChannelRecord>();
        }

        public ICustomerRecord GetCustomerRecord(IDataService dataService, IRecordPointer<Guid> customerId)
        {
            var orgService = dataService.ToOrgService();

            if (customerId.RecordType == "contact")
            {
                return dataService.ToOrgService().Retrieve("contact", customerId.Id, new ColumnSet("contactid","fullname")).ToEntity<Contact>();
            }
            if (customerId.RecordType == "account")
            {
                return dataService.ToOrgService().Retrieve("account", customerId.Id, new ColumnSet("accountid","name")).ToEntity<Account>();
            }

            throw new Exception(string.Format("Customer type '{0}' is not supported.", customerId.RecordType));
        }

        public IList<IRecordClass> GetCustomerClasses(IDataService dataService, IRecordPointer<Guid> customerId)
        {
            throw new NotImplementedException();
        }

        public IEvaluatorTypeRecord GetEvaluatorTypeRecord(IDataService dataService, IRecordPointer<Guid> evaluatorTypeId)
        {
            return dataService.ToOrgService().Retrieve(
                evaluatorTypeId.RecordType, 
                evaluatorTypeId.Id, 
                new ColumnSet("ccllc_evaluatortypeid", "ccllc_name", "ccllc_assemblyname", "ccllc_classname"))
                    .ToEntity<ccllc_evaluatortype>();     
        }

        public IList<ILocation> GetLocationRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_location>()
                .Select("ccllc_locationid", "ccllc_name")
                .RetrieveAll().ToList<ILocation>();
        }

        public IList<IPartner> GetPartnerRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_partner>()
                .Select("ccllc_partnerid", "ccllc_name")
                .WhereAll(e => e.IsActive())
                .RetrieveAll().ToList<IPartner>();
        }



        public IList<IRole> GetRoles(IDataService dataService)
        {           
            return dataService.ToOrgService().Query<ccllc_role>()
                .Select("ccllc_roleid", "ccllc_name")
                .WhereAll(e => e.IsActive())
                .RetrieveAll().ToList<IRole>();
        }

        public IAgentRecord GetUserAgentRecord(IDataService dataService, IRecordPointer<Guid> userId)
        {     
            return dataService.ToOrgService().Query<ccllc_agent>()
                .Select("ccllc_agentid")
                .WhereAll(e => e
                    .IsActive()
                    .Attribute("ccllc_userid").IsEqualTo(userId.Id))
                .FirstOrDefault();

        }

    }
}
