using System;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process.StepType
{
    public abstract class ProcessStepTypeBase : RecordPointer<Guid>, IProcessStepType
    {  
        public abstract bool IsReversable { get; }
        public abstract bool IsUIStep { get; }

        public virtual bool IsConditional { get; set; }

        public string Name { get; }

        public string ImplementationAssembly { get; }

        public string ImplementationClass { get; }

        protected internal ProcessStepTypeBase(string recordType, Guid id, string name, string implementationAssembly, string implementationClass)
            : base(recordType, id)
        {

            this.Name = name;
            this.ImplementationAssembly = implementationAssembly;
            this.ImplementationClass = implementationClass;
        }

        public abstract void Execute(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters);

        public abstract void Rollback(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters);

        public abstract void ValidateStepParameters(IProcessExecutionContext executionContext, ISerializedParameters parameters);

        public abstract IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction, ISerializedParameters parameters);
    }
}
