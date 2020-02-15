using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluatorType : IDeferredImplementation
    {       
        ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, IRecordPointer<Guid> record);

        void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters);
    }
}
