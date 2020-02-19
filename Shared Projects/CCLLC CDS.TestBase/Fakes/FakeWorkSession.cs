using System;
using System.Collections.Generic;
using System.Linq;
using DLaB.Xrm.Test;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.CDS.Test.Fakes
{
    public class FakeWorkSession : IWorkSession
    {
        private List<Id> fakedRoles = new List<Id>();
        private List<Id> fakedChannels = new List<Id>();
        private bool supportAllRoles = false;
        private bool supportAllChannels = false;
        private bool supportAllCustomers = true;

        public IAgent Agent { get; private set; }

        public IChannel Channel => throw new NotImplementedException();

        public ILocation Location { get; private set; }

        public IDevice Workstation => throw new NotImplementedException();

        public IDevice Scanner => throw new NotImplementedException();

        public IDevice Output => throw new NotImplementedException();

        public IDevice Camera => throw new NotImplementedException();

        #region Fluent Builder Methods

        public FakeWorkSession AllowAllChannels()
        {
            supportAllChannels = true;
            return this;
        }

        public FakeWorkSession AllowAllRoles()
        {
            supportAllRoles = true;
            return this;
        }     

        public FakeWorkSession WithAgent(IAgent agent)
        {
            Agent = agent;
            return this;
        }

        public FakeWorkSession WithChannels(params Id[] channels)
        {
            fakedChannels = channels.ToList();
            return this;
        }

        public FakeWorkSession WithLocation(ILocation location)
        {
            Location = location;
            return this;
        }

        public FakeWorkSession WithRoles(params Id[] roles)
        {
            fakedRoles = roles.ToList();
            return this;
        }

        #endregion
        
        public bool CanOperateAgainstCustomer(ICustomer customer)
        {
            return supportAllCustomers;
        }
        public bool HasRole(IRecordPointer<Guid> role)
        {

            return supportAllRoles || (fakedRoles.Where(r => r.EntityId == role.Id).FirstOrDefault() != null);
        }

        public bool HasRole(IEnumerable<IRecordPointer<Guid>> roles)
        {
            if (supportAllRoles) return true;

            foreach(var r in roles)
            {
                if (HasRole(r)) return true;
            }

            return false;
        }

        public bool SupportsChannel(IRecordPointer<Guid> channel)
        {
            return supportAllChannels || (fakedChannels.Where(r => r.EntityId == channel.Id).FirstOrDefault() != null);
        }

        public bool SupportsChannel(IEnumerable<IRecordPointer<Guid>> channels)
        {
            if (supportAllChannels) return true;

            foreach(var c in channels)
            {
                if (SupportsChannel(c)) return true;
            }

            return false;
        }
    }
}
