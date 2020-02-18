
namespace CCLLC.BTF.Process.CDS.Plugins
{
    static class UIPointerExtensions
    {
        public static string Serialize(this IUIPointer uiPointer)
        {
            string structure = "{{\"UIType\":\"{0}\",\"RecordType\":\"{1}\",\"RecordId\":\"{2}\",\"Definition\":\"{3}\"}}";

            return string.Format(
                structure,
                uiPointer.UIType.ToString(),
                uiPointer.UIRecordType,
                uiPointer.UIRecordId.ToString(),
                uiPointer.UIDefinition);
        }
    }
}
