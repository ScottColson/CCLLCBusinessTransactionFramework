using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class PlatformService : IPlatformService
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Platform.Service";

        protected IPlatformDataConnector DataConnector { get; }
        protected IAgentFactory AgentFactory { get; }
        protected ILocationFactory LocationFactory { get; }
        protected IPlatformSettingsFactory SettingsFactory { get; }

        public PlatformService(IPlatformSettingsFactory settingsFactory, IPlatformDataConnector dataConnector, IAgentFactory agentFactory, ILocationFactory locationFactory)
        {
            SettingsFactory = settingsFactory;
            DataConnector = dataConnector;
            AgentFactory = agentFactory;
            LocationFactory = locationFactory;
        }

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, ICustomer customer, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, ISystemUser systemUser, bool useCache = true)
        {
            IAgent agent = AgentFactory.BuildAgent(executionContext, systemUser);

            //temporary implementation until data structures are in place to link a user to a location and channel.
            IChannel channel = this.GetChannels(executionContext).FirstOrDefault(); //Temporary
            ILocation location = DataConnector.GetLocationRecords(executionContext.DataService).FirstOrDefault(); //Temporary
           
            return new WorkSession(agent, channel, location, null, null, null, null);
        }

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, IPartnerWorker partnerWorker, bool useCache = true)
        {
            throw new NotImplementedException();
        }

        public IList<IChannel> GetChannels(IProcessExecutionContext executionContext, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

                TimeSpan? cacheTimeout = null;
                string cacheKey = null;

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    cacheTimeout = settings.ChannelCacheTimeout;
                    cacheKey = CACHE_KEY + "GetChannels";

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        executionContext.Trace("Returned Channels from cache.");
                        return executionContext.Cache.Get<IList<IChannel>>(cacheKey);
                    }
                }

                var channelRecords = DataConnector.GetChannelRecords(executionContext.DataService);

                var partners = this.GetPartners(executionContext, useCache);

                IList<IChannel> channels = new List<IChannel>();
                foreach (var record in channelRecords)
                {
                    var partner = record.PartnerId is null ? null : partners.Where(r => r.Id == record.PartnerId.Id).FirstOrDefault();
                    channels.Add(new Channel(record, partner));
                }

                if(useCache)
                {
                    executionContext.Cache.Add(cacheKey, channels, cacheTimeout.Value);
                }

                return channels;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public IList<IPartner> GetPartners(IProcessExecutionContext executionContext, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

                TimeSpan? cacheTimeout = null;
                string cacheKey = null;

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    cacheTimeout = settings.PartnerCacheTimeout;
                    cacheKey = CACHE_KEY + "GetPartners";

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        executionContext.Trace("Returned Partners from cache.");
                        return executionContext.Cache.Get<IList<IPartner>>(cacheKey);
                    }
                }                
               
                IList<IPartner> partners = DataConnector.GetPartnerRecords(executionContext.DataService);

                if (useCache)
                {
                    executionContext.Cache.Add(cacheKey, partners, cacheTimeout.Value);
                }

                return partners;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<IRole> GetRoles(IProcessExecutionContext executionContext, bool useCache = true)
        {            
            try
            {
                useCache = useCache && executionContext.Cache != null;

                TimeSpan? cacheTimeout = null;
                string cacheKey = null;

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    cacheTimeout = settings.RoleCacheTimeout;
                    cacheKey = CACHE_KEY + "GetRoles";

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        executionContext.Trace("Returned Roles from cache.");
                        return executionContext.Cache.Get<IList<IRole>>(cacheKey);
                    }
                }                

                var roles = DataConnector.GetRoles(executionContext.DataService);

                if (useCache)
                {
                    executionContext.Cache.Add(cacheKey, roles, cacheTimeout.Value);
                }

                return roles;
            }
            catch (Exception)
            {
                throw;
            }
        }
    

        private bool UseCache(IProcessExecutionContext context, TimeSpan? cacheTimeout) => context.Cache != null && cacheTimeout != null;

    }
}
