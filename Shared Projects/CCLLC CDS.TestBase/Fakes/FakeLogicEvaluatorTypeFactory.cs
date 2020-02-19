using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeLogicEvaluatorTypeFactory : ILogicEvaluatorTypeFactory
    {     
        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, string name, string implementationAssemblyName, string implementationClassName, TimeSpan? cacheTimeout = null)
        {
            throw new NotImplementedException();
        }

        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, TimeSpan? cacheTimeout = null)
        {
            return new FakeLogicEvaluatorType(evaluatorTypeId);
        }
    }
}
