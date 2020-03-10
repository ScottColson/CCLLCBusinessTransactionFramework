using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IAgentFactory
    {
        IAgent BuildAgent(IProcessExecutionContext executionContext, IRecordPointer<Guid> agentId, bool useCache = true);

        IAgent BuildAgent(IProcessExecutionContext executionContext, ICustomer customerId, bool useCache = true);

        IAgent BuildAgent(IProcessExecutionContext executionContext, ISystemUser userId, bool useCache = true);

        IAgent BuildAgent(IProcessExecutionContext executionContext, IPartnerWorker workerId, bool useCache = true);

    }
}
