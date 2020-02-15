using System;
using System.Collections.Generic;
using System.Text;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class AgentFactory : IAgentFactory
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Platform.AgentFactory";

        protected IPlatformDataConnector DataConnector { get; }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, IRecordPointer<Guid> agentId, TimeSpan? cacheTimeout = null)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (agentId is null)  throw new ArgumentNullException("agentId");

                string cacheKey = null;
                if(executionContext.Cache != null && cacheTimeout != null)
                {
                    cacheKey = CACHE_KEY + ".Agent." + agentId.Id.ToString();
                }

                if (executionContext.Cache.Exists(cacheKey))
                {
                    executionContext.Trace("Returning Agent from Cache.");
                    return executionContext.Cache.Get<IAgent>(cacheKey);
                }


                var agentRecord = DataConnector.GetAgentRecord(executionContext.DataService, agentId);
                                
                var roles = DataConnector.GetAgentRoles(executionContext.DataService, agentId);

                var authorizedCustomers = DataConnector.GetAgentRoles(executionContext.DataService, agentId);

                var prohibitedCustomers = DataConnector.GetAgentProhibitedCustomers(executionContext.DataService, agentId);
                    
                var agent = new Agent(agentRecord, roles, authorizedCustomers, prohibitedCustomers);

                if (cacheKey != null)
                {
                    executionContext.Trace("Caching Agent for {0}", cacheTimeout.Value);
                    executionContext.Cache.Add<IAgent>(cacheKey, agent, cacheTimeout.Value);
                }

                return agent;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ICustomer customerId, TimeSpan? cacheTimeout = null)
        {
            throw new NotImplementedException();
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ISystemUser userId, TimeSpan? cacheTimeout = null)
        {
            try
            {

                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (userId is null) throw new ArgumentNullException("userId");

                string cacheKey = null;
                if (executionContext.Cache != null && cacheTimeout != null)
                {
                    cacheKey = CACHE_KEY + ".AgentUserMap." + userId.Id.ToString();
                }

                IRecordPointer<Guid> agentId = null;

                if (executionContext.Cache.Exists(cacheKey))
                {
                    agentId = executionContext.Cache.Get<IRecordPointer<Guid>>(cacheKey);
                }
               
                                
                if (agentId is null)
                {
                    agentId = DataConnector.GetUserAgentRecord(executionContext.DataService, userId);

                    if (agentId is null)
                    {
                        throw new Exception("The user does not have an assigend Agent record.");
                    }

                    if (cacheKey != null)
                    {
                        executionContext.Cache.Add<IRecordPointer<Guid>>(cacheKey, agentId, cacheTimeout.Value);
                        executionContext.Trace("Cached User Agent Map for {0}", cacheTimeout.Value);
                    }
                }

                return BuildAgent(executionContext, agentId, cacheTimeout);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, IPartnerWorker workerId, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
