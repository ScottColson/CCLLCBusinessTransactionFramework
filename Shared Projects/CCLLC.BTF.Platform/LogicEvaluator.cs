using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class LogicEvaluator : ILogicEvaluator
    {
        public ILogicEvaluatorType Type { get; }

        public ISerializedParameters Parameters { get; }

        internal protected LogicEvaluator(ILogicEvaluatorType type, ISerializedParameters parameters)
        {
            Type = type;
            Parameters = parameters;
        }

        public ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, IRecordPointer<Guid> record)
        {
            return Type.Evaluate(executionContext, Parameters, record);
        }
        
    }
}
