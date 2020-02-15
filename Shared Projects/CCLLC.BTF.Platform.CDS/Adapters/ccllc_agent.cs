using System;

namespace CCLLC.BTF.Platform.CDS
{
    public partial class ccllc_agent : IAgentRecord
    {
        public string Name => this.ccllc_name;

        public eAgentTypeEnum Type
        {
            get
            {
                if (this.ccllc_AgentType is null) throw new Exception("agentType is required.");

                switch (this.ccllc_AgentType.Value)
                {
                    case ccllc_agent_ccllc_agenttype.SystemUser:
                        return eAgentTypeEnum.InternalUser;
                    case ccllc_agent_ccllc_agenttype.PartnerUser:
                        return eAgentTypeEnum.PartnerUser;
                    case ccllc_agent_ccllc_agenttype.Customer:
                        return eAgentTypeEnum.Customer;
                    default:
                        throw new Exception("Specified Agent Type is not supported.");
                }
            }
        }

        public string RecordType => this.LogicalName;


        
    }
}
