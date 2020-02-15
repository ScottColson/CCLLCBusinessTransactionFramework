using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IPlatformManagerSettings : ISettingsProvider
    {
        TimeSpan? AgentCacheTimeOut { get; }

        TimeSpan? ChannelCacheTimeOut { get; }

        TimeSpan? CustomerCacheTimeOut { get; }

        TimeSpan? LocationCacheTimeOut { get; }

        TimeSpan? PartnerCacheTimeOut { get; }

        TimeSpan? WorkSessionCacheTimeOut { get; }

    }
}
