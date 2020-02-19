using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class EvaluatorTypeBuilder : EntityBuilder<ccllc_evaluatortype>
    {
        private ccllc_evaluatortype Proxy { get; set; }

        public EvaluatorTypeBuilder()
        {
            Proxy = new ccllc_evaluatortype();
        }

        public EvaluatorTypeBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public EvaluatorTypeBuilder WithImplementatingAssembly(string AssemblyName)
        {
            Proxy.ccllc_AssemblyName = AssemblyName;
            return this;
        }

        public EvaluatorTypeBuilder WithImplementatingClass(string ClassName)
        {
            Proxy.ccllc_ClassName = ClassName;
            return this;
        }

        #endregion

        protected override ccllc_evaluatortype BuildInternal()
        {
            return Proxy;
        }

    }
}
