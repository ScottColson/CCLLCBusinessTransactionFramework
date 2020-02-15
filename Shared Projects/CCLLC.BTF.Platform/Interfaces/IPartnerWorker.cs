using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IPartnerWorker : IRecordPointer<Guid>
    {     
        ISystemUser SystemUser {get;}
        Guid PartnerId { get; }
    }
}
