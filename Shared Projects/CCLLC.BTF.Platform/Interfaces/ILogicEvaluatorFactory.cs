using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluatorFactory
    {
        ILogicEvaluator BuildEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, ILogicEvaluatorType evaluatorType, string parameters, TimeSpan? cacheTimeout = null);
        ILogicEvaluator BuildEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, IRecordPointer<Guid> evaluatorTypeId, string evaluatorTypeName, string implementationAssemblyName, string implementationClassName, string parameters, TimeSpan? cacheTimeout = null);
    }
}
