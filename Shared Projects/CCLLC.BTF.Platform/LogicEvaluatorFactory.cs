using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class LogicEvaluatorFactory : ILogicEvaluatorFactory
    {
        private const string CACHE_KEY = "CCLLC.Platform.LogicEvaluatorFactory";

        protected  IParameterSerializer ParameterSerializer { get; }
        protected ILogicEvaluatorTypeFactory EvaluatorTypeFactory { get; }
        protected IPlatformSettingsFactory SettingsFactory { get; }

        public LogicEvaluatorFactory(IPlatformSettingsFactory settingsFactory, ILogicEvaluatorTypeFactory evaluatorTypeFactory, IParameterSerializer parameterSerializer)
        {
            this.SettingsFactory = settingsFactory;
            this.EvaluatorTypeFactory = evaluatorTypeFactory;
            this.ParameterSerializer = parameterSerializer;        
        }

        public ILogicEvaluator CreateEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, ILogicEvaluatorType evaluatorType, string parameters, bool useCache = true)
        {
            string recordKey = CACHE_KEY + evaluatorId.Id.ToString();

            var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

            useCache = useCache && executionContext.Cache != null && cacheTimeout != null;

            if (useCache && executionContext.Cache.Exists(recordKey))
            {
                return executionContext.Cache.Get<ILogicEvaluator>(recordKey);
            }

            var serializedParameter = ParameterSerializer.CreateParamters(parameters);

            var evaluator = new LogicEvaluator(evaluatorType, serializedParameter);

            if (useCache)
            {
                executionContext.Cache.Add<ILogicEvaluator>(recordKey, evaluator, cacheTimeout.Value);
            }

            return evaluator;           
        }


        public ILogicEvaluator CreateEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, IRecordPointer<Guid> evaluatorTypeId, string evaluatorTypeName, string implementationAssemblyName, string implementationClassName, string parameters, bool useCache = true)
        {
            try
            {
                string recordKey = CACHE_KEY + evaluatorId.Id.ToString();

                var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

                useCache = useCache && executionContext.Cache != null && cacheTimeout != null;

                if (useCache && executionContext.Cache.Exists(recordKey))
                {
                    return executionContext.Cache.Get<ILogicEvaluator>(recordKey);
                }
                
                var evaluatorType = this.EvaluatorTypeFactory.BuildEvaluatorType(executionContext, evaluatorTypeId, evaluatorTypeName, implementationAssemblyName, implementationClassName, useCache);

                return this.CreateEvaluator(executionContext, evaluatorId, evaluatorType, parameters);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private TimeSpan? getCacheTimeout(IProcessExecutionContext executionContext)
        {            
            var settings = SettingsFactory.CreateSettings(executionContext.Settings);
            return settings.LogicEvaluatorTimeout;
        }

    }
}
