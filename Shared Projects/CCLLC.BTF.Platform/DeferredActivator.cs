using System;

namespace CCLLC.BTF.Platform
{
    public class DeferredActivator : IDeferredActivator
    {      
        public T InstantiateClass<T>(string recordType, Guid id, string name, string implementationAssemblyName, string implementationClassName) where T : IDeferredImplementation
        {
            try
            {
                T implementation = default(T);
                System.Reflection.Assembly assembly;

                // When using ILMerge reflection cannot locate the assembly by name so we assume the 
                // required implementation has been merged into the executing assembly.
                try
                {
                    assembly = System.Reflection.Assembly.Load(implementationAssemblyName);                    
                }
                catch (Exception)
                {
                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                }

                if(assembly is null) { throw new Exception("Unable to load assembly."); }

                // Instantiate the required implementation class from the assembly and pass in expected arguments.
                object[] args = new object[] {recordType, id, name, implementationAssemblyName, implementationClassName };

                implementation = (T)assembly.CreateInstance(implementationClassName, true, System.Reflection.BindingFlags.CreateInstance, null, args, null, null);
                if (implementation == null)
                {
                    throw new Exception(string.Format("Failed to create class {0}", implementationClassName));
                }

                return implementation;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex);
            }
        }
    }
}
