using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public interface ILogicEvaluatorType : IDeferredImplementation
    {       
        ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, ITransaction transaction);

        void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters);
    }
}
