using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    interface IPartnerFactory
    {
        IPartner BuildPartner(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, bool useCache = true);

        IPartner BuildPartner(IProcessExecutionContext executionContext, Guid id, string name, bool useCache = true);
    }
}
