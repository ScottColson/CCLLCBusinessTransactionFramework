using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface IPlatformSettings : ISettingsProvider
    {
        TimeSpan? AgentCacheTimeout { get; }

        TimeSpan? ChannelCacheTimeout { get; }

        TimeSpan? CustomerCacheTimeout { get; }

        TimeSpan? LocationCacheTimeout { get; }

        TimeSpan? LogicEvaluatorTimeout { get; }

        TimeSpan? LogicEvaluatorTypeTimeout { get; }

        TimeSpan? PartnerCacheTimeout { get; }

        TimeSpan? RoleCacheTimeout { get; }

        TimeSpan? WorkSessionCacheTimeout { get; }

    }
}
