using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;

    static class EntityExtensions
    { 
       public static IRecordPointer<Guid> ToRecordPointer(this EntityReference entityReference)
       {
            return new RecordPointer<Guid>(
                entityReference.LogicalName,
                entityReference.Id);
       }

        public static IRecordPointer<Guid> ToRecordPointer(this Entity entityReference)
        {
            return new RecordPointer<Guid>(
                entityReference.LogicalName,
                entityReference.Id);
        }


        public static void ParseAndAddAttributeValue(this Entity record, string key, string value, AttributeMetadata attributeMetadata)
        {
            switch (attributeMetadata.AttributeType)
            {
                case AttributeTypeCode.String:
                case AttributeTypeCode.Memo:
                    record[key] = value;
                    break;                
                case AttributeTypeCode.Integer:
                    record[key] = Int32.Parse(value);
                    break;                
                case AttributeTypeCode.Double:
                    record[key] = double.Parse(value);
                    break;
                case AttributeTypeCode.Decimal:
                    record[key] = decimal.Parse(value);
                    break;
                case AttributeTypeCode.Boolean:
                    record[key] = Boolean.Parse(value);
                    break;
                case AttributeTypeCode.DateTime:
                    record[key] = DateTime.Parse(value);
                    break;
                case AttributeTypeCode.Picklist:
                    record[key] = new OptionSetValue(Int32.Parse(value));
                    break;
                case AttributeTypeCode.Money:
                    record[key] = new Money(decimal.Parse(value));
                    break;
                case AttributeTypeCode.Lookup:
                    var targetRecordType = (attributeMetadata as LookupAttributeMetadata).Targets[0];
                    record[key] = new EntityReference(targetRecordType, Guid.Parse(value));
                    break;
                default:
                    throw new Exception(string.Format("Cannot set default values for attribute of type {0}", attributeMetadata.AttributeTypeName));

            }

        }

    }
}
