using System;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class ccllc_partner : IPartner
    {
        public string Name => this.ccllc_name;

        public string RecordType => this.LogicalName;

        public Guid RecordId => this.Id;
    }
}
