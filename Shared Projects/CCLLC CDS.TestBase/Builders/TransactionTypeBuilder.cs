using DLaB.Xrm.Test;
using System.Collections.Generic;
using System.Text;
using TestProxy;


namespace CCLLC.CDS.Test.Builders
{
    public class TransactionTypeBuilder : EntityBuilder<ccllc_transactiontype>
    {
        private ccllc_transactiontype Proxy {get; set;}
        private IDictionary<string, string> DataRecordConfig { get; }

        public TransactionTypeBuilder()
        {
            Proxy = new ccllc_transactiontype();
            DataRecordConfig = new Dictionary<string, string>();
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
            DataRecordConfig["RecordType"] = entityLogicalName;
            
            int underScoreIndex = entityLogicalName.IndexOf("_");
            string prefix = entityLogicalName.Substring(0, underScoreIndex+1);

            DataRecordConfig["NameField"] = prefix + "name";
            DataRecordConfig["CustomerField"] = prefix + "customerid";
            DataRecordConfig["TransactionField"] = prefix + "transactionid";          
           
            return this;
        }

        public TransactionTypeBuilder WithDataRecordDefault(string key, string value)
        {
            DataRecordConfig[key] = value;

            return this;
        }
        protected override ccllc_transactiontype BuildInternal()
        {

            bool firstPair = true;

            var builder = new StringBuilder("{");

            foreach(var key in DataRecordConfig.Keys)
            {
                if (!firstPair)                
                    builder.Append(",");               
                else
                    firstPair = false;               

                builder.AppendFormat("\"{0}\":\"{1}\"", key, DataRecordConfig[key]);
            }

            builder.Append("}");

            string json = builder.ToString();
            Proxy.ccllc_DataRecordConfiguration = json;

            return Proxy;
        }
    }
}
