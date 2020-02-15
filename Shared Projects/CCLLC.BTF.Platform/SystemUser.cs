using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public class SystemUser : RecordPointer<Guid>, ISystemUser
    {
       public string Name { get; }

        public SystemUser(string recordType, Guid recordId, string name) : base(recordType,recordId)
        {            
            Name = name;
        }
    }
}
