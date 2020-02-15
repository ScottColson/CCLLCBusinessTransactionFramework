using System;

namespace CCLLC.BTF.Platform.CDS
{ 
    public partial class ccllc_role : IRole
    {
        public string Name => this.ccllc_name;

        public Guid RecordId => this.Id;

        public string RecordType => this.LogicalName;
    }
}
