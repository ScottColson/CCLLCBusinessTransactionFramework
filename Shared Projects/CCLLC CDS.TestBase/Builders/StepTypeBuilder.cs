using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class ProcessStepTypeBuilder : EntityBuilder<ccllc_processsteptype>
    {
        private ccllc_processsteptype Proxy { get; set; }

        public ProcessStepTypeBuilder()
        {
            Proxy = new ccllc_processsteptype();
            Proxy.ccllc_SupportsConditionalBranching = false;
        }

        public ProcessStepTypeBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public ProcessStepTypeBuilder WithImplementatingAssembly(string AssemblyName)
        {
            Proxy.ccllc_AssemblyName = AssemblyName;            
            return this;
        }

        public ProcessStepTypeBuilder WithImplementatingClass(string ClassName)
        {
            Proxy.ccllc_ClassName = ClassName;
            return this;
        }


        public ProcessStepTypeBuilder SupportsConditionalBranching(bool flag = true)
        {
            Proxy.ccllc_SupportsConditionalBranching = flag;
            return this;
        }

        #endregion

        protected override ccllc_processsteptype BuildInternal()
        {
            return Proxy;
        }

    }
}
