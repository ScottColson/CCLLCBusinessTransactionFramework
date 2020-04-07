using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IProcessSettings : ISettingsProvider
    {
        TimeSpan? AlternateBranchCacheTimeout { get; }

        TimeSpan? PlatformServiceCacheTimeout { get; }

        TimeSpan? ProcessStepCacheTimeout { get; }

        TimeSpan? ProcessStepTypeCacheTimeout { get; }

        TimeSpan? TransactionContextCacheTimeout { get; }
        TimeSpan? TransactionProcessCacheTimeout { get; }
        TimeSpan? TransactionRequirementCacheTimeout { get; }
    }
}
