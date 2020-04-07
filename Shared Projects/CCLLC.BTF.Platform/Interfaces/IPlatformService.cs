using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IPlatformService
    {     
        IList<IChannel> GetChannels(IProcessExecutionContext executionContext, bool useCache = true);
       
        IList<IPartner> GetPartners(IProcessExecutionContext executionContext, bool useCache = true);

        IList<IRole> GetRoles(IProcessExecutionContext executionContext, bool useCache = true);


        IWorkSession GenerateSession(IProcessExecutionContext executionContext, ICustomer customer, bool useCache = true);

        IWorkSession GenerateSession(IProcessExecutionContext executionContext, ISystemUser systemUser, bool useCache = true);

        IWorkSession GenerateSession(IProcessExecutionContext executionContext, IPartnerWorker partnerWorker, bool useCache = true);

    }
}
