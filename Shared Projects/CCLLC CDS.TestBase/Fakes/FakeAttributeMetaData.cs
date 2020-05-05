using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeAttributeMetadata : AttributeMetadata
    {
        public FakeAttributeMetadata(AttributeTypeCode typeCode) : base(typeCode) { }
    }
}
