using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IChannelFactory
    {
        IChannel BuildChannel(IProcessExecutionContext executionContext, IRecordPointer<Guid> ChannelId, TimeSpan? cacheTimeOut = null);
    }
}
