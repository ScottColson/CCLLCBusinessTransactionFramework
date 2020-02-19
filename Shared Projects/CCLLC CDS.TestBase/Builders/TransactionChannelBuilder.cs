using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionChannelBulder : EntityBuilder<ccllc_transactiontypeauthorizedchannel>
    {
        private ccllc_transactiontypeauthorizedchannel Proxy { get; set; }

        public TransactionChannelBulder()
        {
            Proxy = new ccllc_transactiontypeauthorizedchannel();
        }

        public TransactionChannelBulder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionChannelBulder ForTransctionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionChannelBulder WithChannel(Id id)
        {
            Proxy.ccllc_ChannelId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transactiontypeauthorizedchannel BuildInternal()
        {            
            return Proxy;
        }

    }
}
