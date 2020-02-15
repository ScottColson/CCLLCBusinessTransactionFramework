using System;
using System.Collections.Generic;
using System.Text;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IEvaluatorTypeRecord : IRecordPointer<Guid>
    {
        string Name { get; }
        string AssemblyName { get; }
        string ClassName { get; }
    }
}
