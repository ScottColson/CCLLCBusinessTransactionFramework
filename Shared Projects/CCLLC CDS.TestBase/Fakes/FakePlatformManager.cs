using System;
using System.Collections.Generic;
using Xrm.Oss.FluentQuery;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using Microsoft.Xrm.Sdk;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakePlatformManager : IPlatformManager
    {      

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, ICustomer customer, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, ISystemUser systemUser, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public IWorkSession GenerateSession(IProcessExecutionContext executionContext, IPartnerWorker partnerWorker, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public IList<IChannel> GetChannels(IProcessExecutionContext executionContext, TimeSpan? cacheTimeOut = null)
        {
            List<IChannel> channels = new List<IChannel>();

            var orgService = executionContext.DataService as IOrganizationService;

            var records = orgService.Query<TestProxy.ccllc_channel>()
                .IncludeAllColumns()
                .RetrieveAll();

            foreach (var r in records)
            {
                channels.Add(new FakeChannel(r));                
            }            

            return channels;            
        }

        public IList<IPartner> GetPartners(IProcessExecutionContext executionContext, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public IList<IRole> GetRoles(IProcessExecutionContext executionContext, TimeSpan? cacheTimeOut = null)
        {
            throw new NotImplementedException();
        }
    }
}
