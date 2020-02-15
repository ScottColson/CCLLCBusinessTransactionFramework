using System;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class ccllc_location : ILocation
    {
        public string RecordType => this.LogicalName;

        public Guid RecordId => this.Id;

        public string Name => this.ccllc_name;
    }
}
