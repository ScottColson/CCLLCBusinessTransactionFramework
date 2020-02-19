using System;
using System.Collections.Generic;
using DLaB.Xrm.Test;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeAgent : IAgent
    {
        public eAgentTypeEnum Type { get; private set; }

        public IReadOnlyList<IRole> Roles => throw new NotImplementedException();

        List<IRecordPointer<Guid>> authorizedCustomers = new List<IRecordPointer<Guid>>();
        public IReadOnlyList<IRecordPointer<Guid>> AuthorizedCustomers => throw new NotImplementedException();

        List<IRecordPointer<Guid>> prohibitedCustomers = new List<IRecordPointer<Guid>>();
        public IReadOnlyList<IRecordPointer<Guid>> ProhibitedCustomers => throw new NotImplementedException();

        public string RecordType { get; }

        public Guid Id { get; }

        public string Name { get; private set; }


        public FakeAgent(Id id)
        {
            RecordType = id.LogicalName;
            Id = id.EntityId;
        }

      

        
    }
}
