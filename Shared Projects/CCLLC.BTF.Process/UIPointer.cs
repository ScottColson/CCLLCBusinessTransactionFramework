using System;

namespace CCLLC.BTF.Process
{
    public class UIPointer : IUIPointer
    {
        public eUIStepTypeEnum UIType { get; set; }

        public string UIRecordType { get; set; }

        public Guid UIRecordId { get; set; }

        public string UIDefinition { get; set; }
    }
}
