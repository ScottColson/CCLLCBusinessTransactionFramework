using System;

namespace CCLLC.BTF.Process
{
    public class UIPointer : IUIPointer
    {
        public eUIStepTypeEnum UIType { get; set; }

        public string UIRecordType { get; set; }

        public Guid UIRecordId { get; set; }

        public string UIDefinition { get; set; }

        public string Serialize()
        {
            string structure = "{{\"UIType\":\"{0}\",\"RecordType\":\"{1}\",\"RecordId\":\"{2}\",\"Definition\":\"{3}\"}}";

            return string.Format(
                structure,
                UIType.ToString(),
                UIRecordType,
                UIRecordId.ToString(),
                UIDefinition);
        }
    }
}
