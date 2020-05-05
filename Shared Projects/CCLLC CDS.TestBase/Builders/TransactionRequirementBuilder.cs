using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionRequirementBuilder : EntityBuilder<ccllc_Requirement>
    {
        private ccllc_Requirement Proxy { get; set; }

        public TransactionRequirementBuilder()
        {
            Proxy = new ccllc_Requirement();
        }

        public TransactionRequirementBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionRequirementBuilder OfType(Id id)
        {
            Proxy.ccllc_EvaluatorTypeId = id.EntityReference;
            return this;
        }

        public TransactionRequirementBuilder WithParameters(string jsonString)
        {
            Proxy.ccllc_RequirementParameters = jsonString;
            return this;
        }

        public TransactionRequirementBuilder ForTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_Requirement BuildInternal()
        {
            return Proxy;
        }

    }
}

