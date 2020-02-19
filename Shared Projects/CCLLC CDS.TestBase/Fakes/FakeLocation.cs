using System;
using DLaB.Xrm.Test;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeLocation : ILocation
    {
        public string RecordType { get; }

        public Guid Id { get; }

        public string Name { get; private set; }

        public FakeLocation(Id id)
        {
            RecordType = id.LogicalName;
            Id = id.EntityId;
        }

        public FakeLocation WithName(string name)
        {
            Name = name;
            return this;
        }
    }
}
