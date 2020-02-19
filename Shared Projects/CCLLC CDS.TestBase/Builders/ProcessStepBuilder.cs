using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class ProcessStepBuilder : EntityBuilder<ccllc_processstep>
    {
        private ccllc_processstep Proxy { get; set; }

        public ProcessStepBuilder()
        {
            Proxy = new ccllc_processstep();  
        }

        public ProcessStepBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public ProcessStepBuilder ForProcess(Id id)
        {
            Proxy.ccllc_TransactionProcessId = id.EntityReference;
            return this;
        }

        public ProcessStepBuilder OfType(Id id)
        {
            Proxy.ccllc_ProcessStepTypeId = id.EntityReference;
            return this;
        }

        public ProcessStepBuilder WithParameters(string jsonString)
        {
            Proxy.ccllc_StepParameters = jsonString;
            return this;
        }

        public ProcessStepBuilder WithSubsequentStep(Id id)
        {
            Proxy.ccllc_SubsequentStepId = id;
            return this;
        }

        #endregion

        protected override ccllc_processstep BuildInternal()
        {
            return Proxy;
        }

    }
}

