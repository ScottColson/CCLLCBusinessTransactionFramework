using System;
using Microsoft.Xrm.Sdk;

namespace CCLLC.BTF.Process.CDS.Plugins
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

    }
}
