using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class AgentFactory : IAgentFactory
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Platform.AgentFactory";

        protected IPlatformDataConnector DataConnector { get; }
        protected IPlatformSettingsFactory SettingsFactory { get; }

        public AgentFactory(IPlatformDataConnector dataConnector, IPlatformSettingsFactory settingsFactory)
        {
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, IRecordPointer<Guid> agentId, bool useCache = true)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (agentId is null)  throw new ArgumentNullException("agentId");

                var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

                useCache = useCache && executionContext.Cache != null && cacheTimeout != null;

                string cacheKey = null;
                if (useCache)
                {
                    cacheKey = CACHE_KEY + ".Agent." + agentId.Id.ToString();
                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        executionContext.Trace("Returning Agent from Cache.");
                        return executionContext.Cache.Get<IAgent>(cacheKey);
                    }
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

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ICustomer customerId, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, ISystemUser userId, bool useCache = true)
        {
            try
            {
                if (executionContext is null) throw new ArgumentNullException("executionContext");
                if (userId is null) throw new ArgumentNullException("userId");

                var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

                useCache = useCache && executionContext.Cache != null && cacheTimeout != null;
                string cacheKey = null;

                IRecordPointer<Guid> agentId = null;

                if (useCache)
                {
                    cacheKey = CACHE_KEY + ".AgentUserMap." + userId.Id.ToString();
                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        agentId = executionContext.Cache.Get<IRecordPointer<Guid>>(cacheKey);
                    }
                }
                
                if (agentId is null)
                {
                    agentId = DataConnector.GetUserAgentRecord(executionContext.DataService, userId);

                    if (agentId is null)
                    {
                        throw new Exception("The user does not have an assigned Agent record.");
                    }

                    if (useCache)
                    {
                        executionContext.Cache.Add<IRecordPointer<Guid>>(cacheKey, agentId, cacheTimeout.Value);
                        executionContext.Trace("Cached User Agent Map for {0}", cacheTimeout.Value);
                    }
                }

                return BuildAgent(executionContext, agentId, useCache);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IAgent BuildAgent(IProcessExecutionContext executionContext, IPartnerWorker workerId, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        private TimeSpan? getCacheTimeout(IProcessExecutionContext executionContext)
        {            
            var settings = SettingsFactory.CreateSettings(executionContext.Settings);
            return settings.AgentCacheTimeout;
        }
    }
}
