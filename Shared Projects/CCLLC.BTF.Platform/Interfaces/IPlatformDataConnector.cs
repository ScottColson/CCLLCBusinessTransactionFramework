using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IPlatformDataConnector
    {
        IAgentRecord GetAgentRecord(IDataService dataService, IRecordPointer<Guid> agentId);
        IAgentRecord GetUserAgentRecord(IDataService dataService, IRecordPointer<Guid> userId);
        IList<IRecordPointer<Guid>> GetAgentAuthorizedCustomers(IDataService dataService, IRecordPointer<Guid> agentId);
        IList<IRecordPointer<Guid>> GetAgentProhibitedCustomers(IDataService dataService, IRecordPointer<Guid> agentId);
        IList<IRole> GetAgentRoles(IDataService dataService, IRecordPointer<Guid> agentId);

        IList<IChannelRecord> GetChannelRecords(IDataService dataService);

        ICustomerRecord GetCustomerRecord(IDataService dataService, IRecordPointer<Guid> customerId);
        IList<IRecordClass> GetCustomerClasses(IDataService dataService, IRecordPointer<Guid> customerId);

        IEvaluatorTypeRecord GetEvaluatorTypeRecord(IDataService dataService, IRecordPointer<Guid> evaluatorTypeId);

        IList<ILocation> GetLocationRecords(IDataService dataService);

        IList<IPartner> GetPartnerRecords(IDataService dataService);

        IList<IRole> GetRoles(IDataService dataService);


    }
}
