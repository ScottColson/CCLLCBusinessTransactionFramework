using System;
using Microsoft.Xrm.Sdk;

namespace CCLLC.BTF.Platform.CDS
{
    using CCLLC.Core;
    using System.Collections.Generic;
    using System.Linq;

    static class ProcessModelExtension
    {
        public static IOrganizationService ToOrgService(this IDataService dataService)
        {
            if (dataService is IOrganizationService)
            {
                return dataService as IOrganizationService;
            }

            throw new Exception("The supplied data service cannot be converted to IOrganizationService.");
        }

        public static EntityReference ToEntityReference(this IRecordPointer<Guid> recordPointer)
        {
            return new EntityReference(recordPointer.RecordType, recordPointer.Id);
        }

        public static IList<IRecordPointer<Guid>> ToRecordPointers(this IList<Entity> records)
        {
            return records.Select(r => r.ToEntityReference().ToRecordPointer()).ToList();
        }
    }
}
