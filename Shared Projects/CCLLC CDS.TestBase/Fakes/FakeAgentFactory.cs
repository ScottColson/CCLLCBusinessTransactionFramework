using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeAgentFactory : IAgentFactory
    {
        public IAgent BuildAgent(IProcessExecutionContext executionContext, IRecordPointer<Guid> agentId, bool useCache = true)
        {
            var service = executionContext.DataService as IOrganizationService;
            var record = service.Retrieve(agentId.RecordType, agentId.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<TestProxy.ccllc_agent>();
            return new FakeAgent(record);
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ICustomer customerId, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ISystemUser userId, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, IPartnerWorker workerId, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
