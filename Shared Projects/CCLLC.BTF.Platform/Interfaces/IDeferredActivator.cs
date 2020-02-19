using System;

namespace CCLLC.BTF.Platform
{
    public interface IDeferredActivator
    {
        T InstantiateClass<T>(string recordType, Guid id, string name, string implementationAssemblyName, string implementationClassName) where T : IDeferredImplementation;
    }
}
