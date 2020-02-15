using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IPlatformManager
    {     
        IList<IChannel> GetChannels(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout = null);
       
        IList<IPartner> GetPartners(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout = null);

        IList<IRole> GetRoles(IProcessExecutionContext executionContext, TimeSpan? cacheTimeout = null);


        IWorkSession GenerateSession(IProcessExecutionContext executionContext, ICustomer customer, TimeSpan? cacheTimeout = null);

        IWorkSession GenerateSession(IProcessExecutionContext executionContext, ISystemUser systemUser, TimeSpan? cacheTimeout = null);

        IWorkSession GenerateSession(IProcessExecutionContext executionContext, IPartnerWorker partnerWorker, TimeSpan? cacheTimeout = null);

    }
}
