using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public interface IProcessStepTypeFactory
    {
        IProcessStepType CreateStepType(IProcessExecutionContext executionContext, IRecordPointer<Guid> processStepTypeId, string name, bool isConditional, string implementationAssemblyName, 
            string implementationClassName, TimeSpan? cacheTimeout = null);
    }
}
