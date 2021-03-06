﻿using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class LogicEvaluatorTypeFactory : ILogicEvaluatorTypeFactory
    {
        protected const string CACHE_KEY = "CCLLC.Platform.LogicEvaluatorTypeFactory";

        protected IDeferredActivator Activator { get; }
        protected IPlatformDataConnector DataConnector { get; }
        protected IPlatformSettingsFactory SettingsFactory { get; }

        public LogicEvaluatorTypeFactory(IPlatformSettingsFactory settingsFactory, IPlatformDataConnector dataConnector, IDeferredActivator activator)
        {
            this.SettingsFactory = settingsFactory ?? throw new ArgumentNullException("settingsFactory");
            this.DataConnector = dataConnector ?? throw new ArgumentNullException("dataConnector");
            this.Activator = activator ?? throw new ArgumentNullException("activator");
        }

        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, bool useCache = true)
        {
            if (evaluatorTypeId is null) throw new ArgumentNullException("evaluatorTypeId");

            var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

            useCache = useCache && executionContext.Cache != null && cacheTimeout != null;

            string cacheKey = null;
            if (useCache)
            {
                cacheKey = CACHE_KEY + evaluatorTypeId.Id.ToString();            
                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<ILogicEvaluatorType>(cacheKey);
                }
            }

            try
            {
                var record = DataConnector.GetEvaluatorTypeRecord(executionContext.DataService, evaluatorTypeId);

                return this.BuildEvaluatorType(executionContext, record, record.Name, record.AssemblyName, record.ClassName);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, string name, string implementationAssemblyName, string implementationClassName, bool useCache = true)
        {
            if (evaluatorTypeId is null) throw new ArgumentNullException("evaluatorTypeId");

            var cacheTimeout = useCache ? getCacheTimeout(executionContext) : null;

            string cacheKey = null;

            if (executionContext.Cache != null && cacheTimeout != null)
            {
                cacheKey = CACHE_KEY + evaluatorTypeId.Id.ToString();
            }

            if (cacheKey != null)
            {
                if (executionContext.Cache.Exists(cacheKey))
                {
                    return executionContext.Cache.Get<ILogicEvaluatorType>(cacheKey);
                }
            }

            try
            {
                var evaluatorType = Activator.InstantiateClass<ILogicEvaluatorType>(evaluatorTypeId.RecordType, evaluatorTypeId.Id, name, implementationAssemblyName, implementationClassName);

                if (cacheKey != null)
                {
                    executionContext.Cache.Add<ILogicEvaluatorType>(cacheKey, evaluatorType, cacheTimeout.Value);
                }

                return evaluatorType;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private TimeSpan? getCacheTimeout(IProcessExecutionContext executionContext)
        {            
            var settings = SettingsFactory.CreateSettings(executionContext.Settings);
            return settings.LogicEvaluatorTypeTimeout;
        }

    }
}
