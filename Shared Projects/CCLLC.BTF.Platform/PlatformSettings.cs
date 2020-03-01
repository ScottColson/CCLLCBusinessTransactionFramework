using System;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public class PlatformSettings : SettingsProvider, IPlatformSettings
    {
        public TimeSpan? AgentCacheTimeout => GetValue<TimeSpan?>("BTF.AgentCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? ChannelCacheTimeout => GetValue<TimeSpan?>("BTF.ChannelCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? CustomerCacheTimeout => GetValue<TimeSpan?>("BTF.CustomerCacheTimeout", TimeSpan.FromSeconds(30));

        public TimeSpan? LocationCacheTimeout => GetValue<TimeSpan?>("BTF.LocationCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? PartnerCacheTimeout => GetValue<TimeSpan?>("BTF.PartnerCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? WorkSessionCacheTimeout => GetValue<TimeSpan?>("BTF.WorkSesssionTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? LogicEvaluatorTimeout => GetValue<TimeSpan?>("BTF.LogicEvaluatorTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? LogicEvaluatorTypeTimeout => GetValue<TimeSpan?>("BTF.LogicEvaluatorTypeTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? RoleCacheTimeout => GetValue<TimeSpan?>("BTF.RoleCacheTimeout", TimeSpan.FromMinutes(10));

        public PlatformSettings(ISettingsProvider settingsProvider) : base(settingsProvider) { }
    }
}
