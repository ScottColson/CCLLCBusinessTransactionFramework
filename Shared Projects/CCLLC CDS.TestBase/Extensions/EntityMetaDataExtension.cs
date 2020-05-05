using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.CDS.TestBase
{
    public static class EntityMetaDataExtension
    {
        public static void SetAttributeCollection(this EntityMetadata entityMetadata, AttributeMetadata[] attributes)
        {
            //AttributeMetadata is internal set in a sealed class so... just doing this
            entityMetadata.GetType().GetProperty("Attributes").SetValue(entityMetadata, attributes, null);
        }
    }
}
