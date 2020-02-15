using System;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public abstract class LogicEvaluatorTypeBase : RecordPointer<Guid>, ILogicEvaluatorType
    {
       
        public string Name { get; }

        public string ImplementationAssembly { get; }
        public string ImplementationClass { get; }

        protected LogicEvaluatorTypeBase(string recordType, Guid id, string name, string implementationAssembly, string implementationClass)
            : base(recordType,id)
        {            
            this.Name = name;
            this.ImplementationAssembly = implementationAssembly;
            this.ImplementationClass = implementationClass;
        }     

        public abstract ILogicEvaluationResult Evaluate(IProcessExecutionContext executionContext, ISerializedParameters parameters, IRecordPointer<Guid> record);

        public abstract void ValidateParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters);
       
    }
}
