using System;
using System.Collections.Generic;
using System.Text;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class LocationFactory : ILocationFactory
    {
        public LocationFactory() { }
        
        public ILocation CreateLocation(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
