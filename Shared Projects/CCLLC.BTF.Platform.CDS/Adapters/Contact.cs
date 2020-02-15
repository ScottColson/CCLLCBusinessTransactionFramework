using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class Contact : ICustomerRecord
    {       
        public string RecordType => this.LogicalName;
        public string Name => this.FullName;

        public eCustomerTypeEnum Type => eCustomerTypeEnum.Contact;
    }

    
}
