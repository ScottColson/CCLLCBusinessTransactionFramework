using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class LogicEvaluatorFactory : ILogicEvaluatorFactory
    {
        private const string CACHE_KEY = "CCLLC.Platform.LogicEvaluatorFactory";

        protected  IParameterSerializer ParameterSerializer { get; }
        protected ILogicEvaluatorTypeFactory EvaluatorTypeFactory { get; }

        public LogicEvaluatorFactory(ILogicEvaluatorTypeFactory evaluatorTypeFactory, IParameterSerializer parameterSerializer)
        {
            this.EvaluatorTypeFactory = evaluatorTypeFactory;
            this.ParameterSerializer = parameterSerializer;        
        }

        public ILogicEvaluator BuildEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, ILogicEvaluatorType evaluatorType, string parameters, TimeSpan? cacheTimeOut = null)
        {
            string recordKey = CACHE_KEY + evaluatorId.Id.ToString();
            bool useCache = executionContext.Cache != null && cacheTimeOut != null;

            if (useCache)
            {
                if (executionContext.Cache.Exists(recordKey))
                {
                    return executionContext.Cache.Get<ILogicEvaluator>(recordKey);
                }
            }

            var serializedParameter = ParameterSerializer.CreateParamters(parameters);

            var evaluator = new LogicEvaluator(evaluatorType, serializedParameter);

            if (useCache)
            {
                executionContext.Cache.Add<ILogicEvaluator>(recordKey, evaluator, cacheTimeOut.Value);
            }

            return evaluator;
           
        }


        public ILogicEvaluator BuildEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, IRecordPointer<Guid> evaluatorTypeId, string evaluatorTypeName, string implementationAssemblyName, string implementationClassName, string parameters, TimeSpan? cacheTimeout = null)
        {
            string recordKey = CACHE_KEY + evaluatorId.Id.ToString();
            bool useCache = executionContext.Cache != null && cacheTimeout != null;

            if (useCache)
            {
                if (executionContext.Cache.Exists(recordKey))
                {
                    return executionContext.Cache.Get<ILogicEvaluator>(recordKey);
                }
            }


            try
            {
                var evaluatorType = this.EvaluatorTypeFactory.BuildEvaluatorType(executionContext, evaluatorTypeId, evaluatorTypeName, implementationAssemblyName, implementationClassName, cacheTimeout);

                return this.BuildEvaluator(executionContext, evaluatorId, evaluatorType, parameters, cacheTimeout);

            }
            catch(Exception)
            {
                throw;
            }
        }
        
    }
}
