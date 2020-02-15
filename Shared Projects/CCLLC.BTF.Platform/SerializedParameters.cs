using System.Collections.Generic;

namespace CCLLC.BTF.Platform
{
    public class SerializedParameters : Dictionary<string,string>, ISerializedParameters
    {
        internal protected SerializedParameters() : base() { }

        internal protected SerializedParameters(IDictionary<string, string> dictionary) : base(dictionary) { }
    }
}
