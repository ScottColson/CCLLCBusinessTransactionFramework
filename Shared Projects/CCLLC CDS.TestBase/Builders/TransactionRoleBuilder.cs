using System;
using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class TransactionRoleBuilder : EntityBuilder<ccllc_transactiontypeauthorizedrole>
    {
        private ccllc_transactiontypeauthorizedrole Proxy { get; set; }

        public TransactionRoleBuilder()
        {
            Proxy = new ccllc_transactiontypeauthorizedrole();
        }

        public TransactionRoleBuilder(Id id) : this()
        {
            Id = id;
        }

        #region Fluent Methods

        public TransactionRoleBuilder ForTransactionType(Id id)
        {
            Proxy.ccllc_TransactionTypeId = id.EntityReference;
            return this;
        }

        public TransactionRoleBuilder WithRole(Id id)
        {
            Proxy.ccllc_RoleId = id.EntityReference;
            return this;
        }

        #endregion

        protected override ccllc_transactiontypeauthorizedrole BuildInternal()
        {            
            return Proxy;
        }

    }
}
