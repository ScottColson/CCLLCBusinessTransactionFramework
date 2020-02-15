using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class Account : ICustomerRecord
    {        
        public string RecordType => this.LogicalName;
        public eCustomerTypeEnum Type => eCustomerTypeEnum.Account;     
    }
}
