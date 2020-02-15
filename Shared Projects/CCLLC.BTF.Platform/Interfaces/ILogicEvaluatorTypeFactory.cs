using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluatorTypeFactory
    {
        ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, string name, string implementationAssemblyName, string implementationClassName, TimeSpan? cacheTimeout = null);

        ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, TimeSpan? cacheTimeout = null);
    }
}
