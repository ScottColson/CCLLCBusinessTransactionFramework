using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    internal class WeightedEvidenceEvaluator : ILogicEvaluator
    {
        public ILogicEvaluatorType Type { get; }

        public ISerializedParameters Parameters { get; }

        internal WeightedEvidenceEvaluator()
        {
            this.Type = new WeightedEvidenceEvaluatorType();
        }

        public ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, Platform.ITransaction transaction)
        {
            return Type.Evaluate(executionContext, Parameters, transaction);
        }
       
    }

    internal class WeightedEvidenceEvaluatorType : RecordPointer<Guid>, ILogicEvaluatorType
    {      
        public string Name => throw new NotImplementedException();

        public string ImplementationAssembly => throw new NotImplementedException();

        public string ImplementationClass => throw new NotImplementedException();

        public ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, Platform.ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
