namespace CCLLC.BTF.Process.CDS
{   
    public partial class ccllc_processsteptype : IProcessStepTypeRecord
    {
        public string RecordType => this.LogicalName;

        public string Name => this.ccllc_name;

        public string ClassName => this.ccllc_ClassName;

        public string AssemblyName => this.ccllc_AssemblyName;

        public bool? SupportsConditionalBranching => this.ccllc_SupportsConditionalBranching;
    }
}
