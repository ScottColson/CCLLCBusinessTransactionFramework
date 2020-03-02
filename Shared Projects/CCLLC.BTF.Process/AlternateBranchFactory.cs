using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class AlternateBranchFactory : IAlternateBranchFactory
    {
        protected const string CACHE_KEY = "CCLLC.BTF.Process.AlternateBranchFactory";

        protected ILogicEvaluatorTypeFactory EvaluatorTypeFactory { get; }
        protected ILogicEvaluatorFactory EvaluatorFactory { get; }
        protected IProcessSettingsFactory SettingsFactory { get; }

        public AlternateBranchFactory(IProcessSettingsFactory settingsFactory, ILogicEvaluatorTypeFactory evaluatorTypeFactory, ILogicEvaluatorFactory evaluatorFactory)
        {
            SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            EvaluatorTypeFactory = evaluatorTypeFactory ?? throw new ArgumentNullException("evaluatorTypeFactory");
            EvaluatorFactory = evaluatorFactory ?? throw new ArgumentNullException("evaluatorFactory");
        }

        public IAlternateBranch CreateAlternateBranch(IProcessExecutionContext executionContext, IRecordPointer<Guid> alternateBranchId, string name, int evaluationOrder, IRecordPointer<Guid> parentStepId, IRecordPointer<Guid> subsequentStepId, IRecordPointer<Guid> evaluatorTypeId, string parameters, bool useCache = true)
        {
            try
            {
                useCache = useCache && executionContext.Cache != null;

                string cacheKey = null;
                
                if (useCache)
                {
                    cacheKey = CACHE_KEY + alternateBranchId.ToString();

                    if (executionContext.Cache.Exists(cacheKey))
                    {
                        return executionContext.Cache.Get<IAlternateBranch>(cacheKey);
                    }
                }

                if (evaluatorTypeId is null) throw new ArgumentNullException("evaluatorTypeId");

                var evaluatorType = EvaluatorTypeFactory.BuildEvaluatorType(executionContext, evaluatorTypeId, useCache);
                var evaluator = EvaluatorFactory.CreateEvaluator(executionContext, alternateBranchId, evaluatorType, parameters, useCache);

                var alternateBranch = new AlternateBranch(alternateBranchId.RecordType,alternateBranchId.Id, name, evaluationOrder, parentStepId, subsequentStepId, evaluator);

                if (useCache)
                {
                    var settings = SettingsFactory.CreateSettings(executionContext.Settings);
                    var cacheTimeout = settings.AlternateBranchCacheTimeout;

                    executionContext.Cache.Add<IAlternateBranch>(cacheKey, alternateBranch, cacheTimeout.Value);
                }

                return alternateBranch;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
