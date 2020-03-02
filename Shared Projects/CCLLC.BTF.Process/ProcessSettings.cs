using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public class ProcessSettings : SettingsProvider, IProcessSettings
    {
        public TimeSpan? AlternateBranchCacheTimeout => GetValue<TimeSpan?>("BTF.AlternateBranchCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? PlatformManagerCacheTimeout => GetValue<TimeSpan?>("BTF.PlatformManagerCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? ProcessStepCacheTimeout => GetValue<TimeSpan?>("BTF.ProcessStepCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? ProcessStepTypeCacheTimeout => GetValue<TimeSpan?>("BTF.ProcessStepTypeCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? TransactionContextCacheTimeout => GetValue<TimeSpan?>("BTF.TransactionContextCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? TransactionProcessCacheTimeout => GetValue<TimeSpan?>("BTF.TransactionProcessCacheTimeout", TimeSpan.FromMinutes(10));

        public TimeSpan? TransactionRequirementCacheTimeout => GetValue<TimeSpan?>("BTF.TransactionRequirementCacheTimeout", TimeSpan.FromMinutes(10));

        public ProcessSettings(ISettingsProvider settings) : base(settings) { }
    }
}
