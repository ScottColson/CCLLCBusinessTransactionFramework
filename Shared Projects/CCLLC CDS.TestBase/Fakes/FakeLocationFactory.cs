using System;
using Microsoft.Xrm.Sdk;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeLocationFactory : ILocationFactory
    {      
        public ILocation CreateLocation(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, bool useCache = true)
        {
            var service = executionContext.DataService as IOrganizationService;
            var record = service.Retrieve(locationId.RecordType, locationId.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<TestProxy.ccllc_location>();
            return new FakeLocation(record);
        }
    }
}
