using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class TransactionProcessFactory : ITransactionProcessFactory
    {
        private const string CACHE_KEY = "CCLLC.BTF.TransactionProcessFactory";

        private IProcessSettingsFactory SettingsFactory { get; }

        public TransactionProcessFactory(IProcessSettingsFactory settingsFactory)
        {
            SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
        }

        public ITransactionProcess CreateTransactionProcess(IProcessExecutionContext executionContext, IRecordPointer<Guid> processId, string name, IRecordPointer<Guid> transactionTypeId, IRecordPointer<Guid> initialStepId, IEnumerable<IProcessStep> processSteps, bool useCache = true)
        {
            if (executionContext is null) throw new ArgumentNullException("executionContext");
            if (processId is null) throw new ArgumentNullException("processId");

            useCache = useCache && executionContext.Cache != null;

            string cacheKey = null;
            if (useCache)
            {
                cacheKey = CACHE_KEY + processId.Id.ToString();
            
                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<ITransactionProcess>(cacheKey);
                }
            }

            try
            {
                if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("name is null."); }
                if (transactionTypeId == null) { throw new ArgumentNullException("transactionTypeId is null."); }
                if (initialStepId == null) { throw new ArgumentNullException("initiailStepId is null."); }
                if (processSteps == null) { throw new ArgumentNullException("processSteps is null."); }

                var process = new TransactionProcess(processId, name, transactionTypeId, initialStepId.Id, processSteps);

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    var cacheTimeout = settings.TransactionProcessCacheTimeout;

                    executionContext.Cache.Add<ITransactionProcess>(cacheKey, process, cacheTimeout.Value);
                }

                return process;
            }          
            catch (Exception ex)
            {
                throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessInvalid, ex);
            }
        }
    }
}
