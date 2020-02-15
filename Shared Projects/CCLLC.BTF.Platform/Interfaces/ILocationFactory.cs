using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILocationFactory
    {
        ILocation BuildLocation(IProcessExecutionContext executionContext, IRecordPointer<Guid> locationId, TimeSpan? cacheTimeout = null);
    }
}
