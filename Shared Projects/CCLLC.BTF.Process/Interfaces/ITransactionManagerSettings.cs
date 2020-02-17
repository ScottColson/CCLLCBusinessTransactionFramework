using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.Interfaces
{
    public interface ITransactionManagerSettings : ISettingsProvider
    {
        TimeSpan? ContextRecordCacheTimeOut { get; }

        TimeSpan? DataRecordCacheTimeOut { get; }

        TimeSpan? TrannsactionManagerCacheTimeout { get; }
    }
}
