using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Oss.FluentQuery;

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
                  .IncludeColumns("ccllc_customerid")
                  .Where(e => e
                      .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                      .Attribute(a => a.Named("ccllc_agentid").Is(ConditionOperator.Equal).To(agentId.Id))
                      .Attribute(a => a.Named("ccllc_customerid").Is(ConditionOperator.NotNull)))
                   .RetrieveAll().Select(r => r.ccllc_CustomerId.ToRecordPointer()).ToList();
        }

        public IList<IRecordPointer<Guid>> GetAgentProhibitedCustomers(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Query<ccllc_agentprohibitedcustomer>()
                  .IncludeColumns("ccllc_customerid")
                  .Where(e => e
                      .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                      .Attribute(a => a.Named("ccllc_agentid").Is(ConditionOperator.Equal).To(agentId.Id))
                      .Attribute(a => a.Named("ccllc_customerid").Is(ConditionOperator.NotNull)))
                   .RetrieveAll().Select(r => r.ccllc_CustomerId.ToRecordPointer()).ToList();
        }

        public IAgentRecord GetAgentRecord(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Retrieve(agentId.RecordType, agentId.Id, new ColumnSet(true)).ToEntity<ccllc_agent>();
        }

        public IList<IRole> GetAgentRoles(IDataService dataService, IRecordPointer<Guid> agentId)
        {
            return dataService.ToOrgService().Query<ccllc_role>()
                    .IncludeColumns("ccllc_roleid", "ccllc_name")
                    .Where(e => e
                        .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                    .Link(l => l
                        .FromEntity(ccllc_role.EntityLogicalName)
                        .FromAttribute("ccllc_roleid")
                        .ToEntity(ccllc_agentrole.EntityLogicalName)
                        .ToAttribute("ccllc_roleid")
                        .Where(e => e.
                            Attribute(a => a.Named("ccllc_agentid").Is(ConditionOperator.Equal).To(agentId.Id))))
                    .RetrieveAll().ToList<IRole>();           
        }


        public IList<IChannelRecord> GetChannelRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_channel>()
                .IncludeAllColumns()
                .Where(e => e.Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
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
                .IncludeColumns("ccllc_locationid", "ccllc_name")
                .RetrieveAll().ToList<ILocation>();
        }

        public IList<IPartner> GetPartnerRecords(IDataService dataService)
        {
            return dataService.ToOrgService().Query<ccllc_partner>()
                .IncludeColumns("ccllc_partnerid", "ccllc_name")
                .Where(e => e.Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0)))
                .RetrieveAll().ToList<IPartner>();
        }



        public IList<IRole> GetRoles(IDataService dataService)
        {           
            return dataService.ToOrgService().Query<ccllc_role>()
                .IncludeColumns("ccllc_roleid", "ccllc_name")
                .Where(e => e.Attribute(a => a.Named("statecode").Is(Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal).To(0)))
                .RetrieveAll().ToList<IRole>();
        }

        public IAgentRecord GetUserAgentRecord(IDataService dataService, IRecordPointer<Guid> userId)
        {     
            return dataService.ToOrgService().Query<ccllc_agent>()
                .IncludeColumns("ccllc_agentid")
                .Where(e => e
                    .Attribute(a => a.Named("statecode").Is(ConditionOperator.Equal).To(0))
                    .Attribute(a => a.Named("ccllc_userid").Is(ConditionOperator.Equal).To(userId.Id)))
                .RetrieveAll().FirstOrDefault().ToEntity<ccllc_agent>();

        }

    }
}
