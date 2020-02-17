using System;

namespace CCLLC.BTF.Process
{
    public interface IUIPointer
    {
        eUIStepTypeEnum UIType { get; }
        string UIRecordType { get; }
        Guid UIRecordId { get; }
        string UIDefinition { get; }
    }
}
