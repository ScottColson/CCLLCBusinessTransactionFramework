using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IEvidenceType : IRecordPointer<Guid>
    {        
        string Name { get; }
        eEvidienceCategoryEnum Catetory { get; }
    }
}
