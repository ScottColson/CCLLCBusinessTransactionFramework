

namespace CCLLC.BTF.Platform.CDS
{
    public partial class ccllc_evaluatortype : IEvaluatorTypeRecord
    {
        public string RecordType => this.LogicalName;
        public string Name => this.ccllc_name;
        public string AssemblyName => this.ccllc_AssemblyName;
        public string ClassName => this.ccllc_ClassName;        
    }
}
