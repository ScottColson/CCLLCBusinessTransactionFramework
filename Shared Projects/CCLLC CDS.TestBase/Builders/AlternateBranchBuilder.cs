using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class AlternateBranchBuilder : EntityBuilder<ccllc_alternatebranch>
    {
        private ccllc_alternatebranch Proxy { get; set; }

        public AlternateBranchBuilder()
        {
            Proxy = new ccllc_alternatebranch();
        }

        public AlternateBranchBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public AlternateBranchBuilder ForStep(Id id)
        {
            Proxy.ccllc_ParentStepId = id.EntityReference;
            return this;
        }

        public AlternateBranchBuilder WithEvaluatorType(Id id)
        {
            Proxy.ccllc_EvaluatorTypeId = id.EntityReference;
            return this;
        }

        public AlternateBranchBuilder WithParameters(string jsonString)
        {
            Proxy.ccllc_EvaluationParameters = jsonString;
            return this;
        }

        public AlternateBranchBuilder WithEvlauationOrder(int rank)
        {
            Proxy.ccllc_EvaluationOrder = rank;
            return this;
        }

        public AlternateBranchBuilder GoesToStep(Id id)
        {
            Proxy.ccllc_SubsequentStepId = id;
            return this;
        }

        #endregion

        protected override ccllc_alternatebranch BuildInternal()
        {
            return Proxy;
        }

    }
}
