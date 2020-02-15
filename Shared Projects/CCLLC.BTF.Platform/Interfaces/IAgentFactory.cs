using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IAgentFactory
    {
        IAgent BuildAgent(IProcessExecutionContext executionContext, IRecordPointer<Guid> agentId, TimeSpan? cacheTimeOut = null);

        IAgent BuildAgent(IProcessExecutionContext executionContext, ICustomer customerId, TimeSpan? cacheTimeOut = null);

        IAgent BuildAgent(IProcessExecutionContext executionContext, ISystemUser userId, TimeSpan? cacheTimeOut = null);

        IAgent BuildAgent(IProcessExecutionContext executionContext, IPartnerWorker workerId, TimeSpan? cacheTimeOut = null);

    }
}
