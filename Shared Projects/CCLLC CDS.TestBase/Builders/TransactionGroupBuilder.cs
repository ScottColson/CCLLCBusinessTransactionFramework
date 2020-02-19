using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionGroupBuilder : EntityBuilder<ccllc_transactiongroup>
    {
        private ccllc_transactiongroup Proxy { get; set; }

        public TransactionGroupBuilder()
        {
            Proxy = new ccllc_transactiongroup();
        }

        public TransactionGroupBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionGroupBuilder WithDisplayRank(int rank)
        {
            Proxy.ccllc_DisplayRank = rank;
            return this;
        }

        #endregion

        protected override ccllc_transactiongroup BuildInternal()
        {
            return Proxy;
        }

    }
}
