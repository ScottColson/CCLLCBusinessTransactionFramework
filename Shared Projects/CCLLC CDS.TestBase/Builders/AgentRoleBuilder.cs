using DLaB.Xrm.Test;
using TestProxy;

namespace CCLLC.CDS.Test.Builders
{
    public class AgentRoleBuilder : EntityBuilder<ccllc_agentrole>
    {
        private ccllc_agentrole AgentRole { get; set; }

        public AgentRoleBuilder()
        {
            AgentRole = new ccllc_agentrole();
        }

        public AgentRoleBuilder(Id id) : this()
        {
            Id = id;
        }

        public AgentRoleBuilder ForAgent(Id agentId)
        {
            AgentRole.ccllc_AgentId = agentId.EntityReference;
            return this;
        }

        public AgentRoleBuilder WithRole(Id roleId)
        {
            AgentRole.ccllc_RoleId = roleId.EntityReference;
            return this;
        }

        protected override ccllc_agentrole BuildInternal()
        {
            return AgentRole;
        }
    }
}
