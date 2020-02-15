using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    interface IPartnerFactory
    {
        IPartner BuildPartner(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, TimeSpan? cacheTimeOut = null);

        IPartner BuildPartner(IProcessExecutionContext executionContext, Guid id, string name, TimeSpan? cacheTimeOut = null);
    }
}
