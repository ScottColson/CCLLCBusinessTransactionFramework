using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class StepHistoryBuilder : EntityBuilder<ccllc_stephistory>
    {
        private ccllc_stephistory Proxy { get; set; }

        public StepHistoryBuilder()
        {
            Proxy = new ccllc_stephistory();
            Proxy.statuscode = ccllc_stephistory_statuscode.Current;
        }

        public StepHistoryBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public StepHistoryBuilder ForTransaction(Id id)
        {
            Proxy.ccllc_TransactionId = id.EntityReference;
            return this;
        }

        public StepHistoryBuilder ForStep(Id id)
        {
            Proxy.ccllc_ProcessStepId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_stephistory BuildInternal()
        {
            return Proxy;
        }

    }
}

