using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeLogicEvaluatorTypeFactory : ILogicEvaluatorTypeFactory
    {     
        

        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, bool useCache = true)
        {
            return new FakeLogicEvaluatorType(evaluatorTypeId);
        }

        public ILogicEvaluatorType BuildEvaluatorType(IProcessExecutionContext executionContext, IRecordPointer<Guid> evaluatorTypeId, string name, string implementationAssemblyName, string implementationClassName, bool useCache = true)
        {
            throw new NotImplementedException();
        }
    }
}
