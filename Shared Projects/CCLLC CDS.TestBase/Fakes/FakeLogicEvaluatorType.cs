using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using DLaB.Xrm.Test;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeLogicEvaluatorType : ILogicEvaluatorType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImplementationAssembly { get; set; }

        public string ImplementationClass { get; set; }

        public string RecordType  {get; set;}

        public FakeLogicEvaluatorType(string recordType, Guid id)
        {
            RecordType = recordType;
            Id = id;
        }

        public FakeLogicEvaluatorType(Id id)
        {
            RecordType = id.LogicalName;
            Id = id;            
        }

        public FakeLogicEvaluatorType(IRecordPointer<Guid> id)
        {
            RecordType = id.RecordType;
            Id = id.Id; ;
        }

        public ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, ITransaction transaction)
        {
            ValidateParameters(executionContext, parameters);

            var value = parameters["EvaluateAs"];

            bool result;
            if (bool.TryParse(value, out result) && result)
            {
                return new LogicEvaluationResult(true, string.Empty);
            }

            return new LogicEvaluationResult(false, string.Empty);                       
        }

        public void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters)
        {
            if (!parameters.ContainsKey("EvaluateAs")) throw new Exception("FakeLogicEvaluatorType requires a parameter named 'EvaluateAs' that contains a boolean value.");
        }
    }
}
