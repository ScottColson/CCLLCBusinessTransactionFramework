using System;
using System.Collections.Generic;
using CCLLC.Core;

namespace CCLLC.BTF.Platform
{
    public class WorkSession : IWorkSession
    {
        public IAgent Agent { get; }

        public IChannel Channel { get; }

        public ILocation Location { get; }

        public IDevice Workstation { get; }

        public IDevice Scanner { get; }

        public IDevice Output { get; }

        public IDevice Camera { get; }

        public WorkSession(IAgent agent, IChannel channel, ILocation location, IDevice workstation, IDevice Scanner, IDevice Output, IDevice Camera)
        {
            this.Agent = agent;
            this.Channel = channel;
            this.Location = location;
            this.Workstation = workstation;
            this.Scanner = Scanner;
            this.Output = Output;
            this.Camera = Camera;
        }

        public bool CanOperateAgainstCustomer(ICustomer customer)
        {
            if (customer == null) return false;
            if (this.Agent == null) return false;

            foreach(var c in Agent.ProhibitedCustomers)
            {
                if (c.Id == customer.Id) return false;
            }

            if(Channel != null && this.Channel.CustomerScope == eChannelCustomerScopeEnum.AnyCustomers)
            {
                return true; //can operate against any non-prohibited customers
            }
            else
            {
                //only authorized customers
                foreach (var c in Agent.AuthorizedCustomers)
                {
                    if (c.Id == customer.Id) return true;
                }
            }

            return false;           
        }

        public bool HasRole(IRecordPointer<Guid> role)
        {
            if (this.Agent == null) return false;

            if (role != null)
            {
                foreach (var r in Agent.Roles)
                {
                    if (r.Id == role.Id) return true; 
                }
            }

            return false;
        }

        public bool HasRole(IEnumerable<IRecordPointer<Guid>> roles)
        {
            foreach (var role in roles)
            {
                if (this.HasRole(role)) return true; 
            }

            return false;
        }

        public bool SupportsChannel(IRecordPointer<Guid> channel)
        {
            return channel != null && this.Channel != null && channel.Id == this.Channel.Id;
        }

        public bool SupportsChannel(IEnumerable<IRecordPointer<Guid>> channels)
        {
            foreach(var channel in channels)
            {
                if (this.SupportsChannel(channel)) return true;
            }

            return false;
        }
    }
}
