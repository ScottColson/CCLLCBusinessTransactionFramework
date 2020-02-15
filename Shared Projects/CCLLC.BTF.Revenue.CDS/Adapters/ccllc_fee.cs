using System;

namespace CCLLC.BTF.Revenue.CDS
{
    public partial class ccllc_fee : IFee
    {
        public string Name => this.ccllc_name;       

        public string RecordType => this.LogicalName;
    }
}
