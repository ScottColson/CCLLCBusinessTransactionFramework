using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILocationFactory
    {
        ILocation CreateLocation(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, bool useCache = true);
    }
}
