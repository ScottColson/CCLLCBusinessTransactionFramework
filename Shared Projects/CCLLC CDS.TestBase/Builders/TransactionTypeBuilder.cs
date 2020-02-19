using DLaB.Xrm.Test;
using TestProxy;


namespace CCLLC.CDS.Test.Builders
{
    public class TransactionTypeBuilder : EntityBuilder<ccllc_transactiontype>
    {
        private ccllc_transactiontype Proxy {get; set;}

        public TransactionTypeBuilder()
        {
            Proxy = new ccllc_transactiontype();
        }

        public TransactionTypeBuilder(Id id) : this()
        {
            Id = id;
        }

        public TransactionTypeBuilder InGroup(Id id)
        {
            Proxy.ccllc_TransactionGroupId = id.EntityReference;
            return this;            
        }

        public TransactionTypeBuilder WithStartupProcess(Id id)
        {
            Proxy.ccllc_StartupProcessId = id.EntityReference;
            return this;
        }

        public TransactionTypeBuilder WithDisplayRank(int rank)
        {
            Proxy.ccllc_DisplayRank = rank;
            return this;
        }
       
        public TransactionTypeBuilder WithDataRecordType(string entityLogicalName)
        {
            int underScoreIndex = entityLogicalName.IndexOf("_");
            string prefix = entityLogicalName.Substring(0, underScoreIndex+1);
            string nameField = prefix + "name";
            string customerField = prefix + "customerid";
            string transactionField = prefix + "transactionid";

            string json = "{\"RecordType\":\"" + entityLogicalName + "\",\"NameField\":\"" + nameField + "\",\"CustomerField\":\"" + customerField + "\",\"TransactionField\":\"" + transactionField + "\"}";
            Proxy.ccllc_DataRecordConfiguration = json;

            return this;
        }

        protected override ccllc_transactiontype BuildInternal()
        {
            return Proxy;
        }
    }
}
