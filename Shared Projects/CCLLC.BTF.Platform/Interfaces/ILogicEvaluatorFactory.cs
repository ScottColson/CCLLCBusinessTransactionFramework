using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluatorFactory
    {
        ILogicEvaluator CreateEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, ILogicEvaluatorType evaluatorType, string parameters, bool useCache = true);
        ILogicEvaluator CreateEvaluator(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorId, IRecordPointer<Guid> evaluatorTypeId, string evaluatorTypeName, string implementationAssemblyName, string implementationClassName, string parameters, bool useCache = true);
    }
}
