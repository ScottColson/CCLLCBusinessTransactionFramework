using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IProcessSettings : ISettingsProvider
    {
        TimeSpan? AlternateBranchCacheTimeout { get; }

        TimeSpan? PlatformManagerCacheTimeout { get; }

        TimeSpan? ProcessStepCacheTimeout { get; }

        TimeSpan? ProcessStepTypeCacheTimeout { get; }

        TimeSpan? TransactionContextCacheTimeout { get; }
        TimeSpan? TransactionProcessCacheTimeout { get; }
        TimeSpan? TransactionRequirementCacheTimeout { get; }
    }
}
