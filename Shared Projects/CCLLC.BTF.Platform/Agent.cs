using System;
using System.Collections.Generic;
using System.Linq;

namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public class Agent : RecordPointer<Guid>, IAgent
    {
        public eAgentTypeEnum Type { get; }

        public IReadOnlyList<IRole> Roles { get; }

        public IReadOnlyList<IRecordPointer<Guid>> AuthorizedCustomers { get; }

        public IReadOnlyList<IRecordPointer<Guid>> ProhibitedCustomers { get; }
               
        public string Name { get; }

        public Agent(IAgentRecord agentRecord, IEnumerable<IRole> roles, IEnumerable<IRecordPointer<Guid>> authorizedCustomers,
          IEnumerable<IRecordPointer<Guid>> prohibitedCustomers) 
            : base(agentRecord.RecordType,agentRecord.Id)
        {
            try
            {               
                Name = agentRecord.Name ?? throw new ArgumentNullException("name");
                Type = agentRecord.Type;
                Roles = roles?.ToList() ?? throw new ArgumentNullException("roles");
                AuthorizedCustomers = authorizedCustomers?.ToList() ?? throw new ArgumentNullException("authorizedCustomers");
                ProhibitedCustomers = prohibitedCustomers?.ToList() ?? throw new ArgumentNullException("prohibitedCustomers");

                if(Type == eAgentTypeEnum.Customer && AuthorizedCustomers.Count <= 0) throw new Exception("Customer agent must have at least one authorized customer.");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
