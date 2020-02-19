using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class AgentBuilder : EntityBuilder<ccllc_agent>
    {
        private ccllc_agent Agent { get; set; }

        public AgentBuilder()
        {
            Agent = new ccllc_agent();
        }

        public AgentBuilder(Id id) : this()
        {
            Id = id;
        }

        public AgentBuilder ForUser(Id userId)
        {
            Agent.ccllc_UserId = userId.EntityReference;
            Agent.ccllc_AgentType = ccllc_agent_ccllc_agenttype.SystemUser;
            return this;
        }


        protected override ccllc_agent BuildInternal()
        {
            return Agent;
        }
    }
}
