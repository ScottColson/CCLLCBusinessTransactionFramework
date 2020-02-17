using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class TransactionType : RecordPointer<Guid>, ITransactionType
    {
        private List<ITransactionRequirement> _requirements;
        private List<IRecordPointer<Guid>> _authorizedRoles;
        private List<ITransactionProcess> _availableProcesses;
        private List<IContextType> _eligibleContexts;
        private List<IRecordPointer<Guid>> _authorizedChannels;
        private List<IRecordPointer<Guid>> _initialFeeSchedule;
       
        public string Name { get; }

        public int DisplayRank { get;  }

        public ITransactionGroup Group { get;  }

        public Guid StartUpProcessId { get;  }

        public ISerializedParameters TransactionDataRecordType { get; }               

        public IReadOnlyList<IRecordPointer<Guid>> AuthorizedChannels => _authorizedChannels;

        public IReadOnlyList<IRecordPointer<Guid>> AuthorizedRoles => _authorizedRoles;

        public IReadOnlyList<ITransactionProcess> AvailableProcesses => _availableProcesses;

        public IReadOnlyList<IContextType> EligibleContexts => _eligibleContexts;       

        public IReadOnlyList<IRecordPointer<Guid>> InitialFeeSchedule => _initialFeeSchedule;

        public IReadOnlyList<ITransactionRequirement> Requirements => _requirements;

        public IReadOnlyList<string> AffectedRecordTypes => throw new NotImplementedException();

        protected internal TransactionType(IRecordPointer<Guid> transactionTypeId, string name, int displayRank, ITransactionGroup group, Guid startupProcessId, ISerializedParameters dataRecordType, IEnumerable<IRecordPointer<Guid>> authorizedChannels, IEnumerable<IRecordPointer<Guid>> authorizedRoles, IEnumerable<ITransactionProcess> processes, IEnumerable<ITransactionRequirement> requirements, IEnumerable<IRecordPointer<Guid>> initialFees, IEnumerable<IContextType> contexts )
        : base(transactionTypeId)
        {            
            this.Name = name;
            this.DisplayRank = displayRank;
            this.Group = group;
            this.StartUpProcessId = startupProcessId;
            this.TransactionDataRecordType = dataRecordType ??  throw new ArgumentNullException("dataRecordType"); ;
            _authorizedChannels = authorizedChannels != null ? authorizedChannels.ToList() : throw new ArgumentNullException("authorizedChannel");
            _authorizedRoles = authorizedRoles != null ? authorizedRoles.ToList() : throw new ArgumentNullException("authorizedRoles");
            _availableProcesses = processes != null ? processes.ToList() : throw new ArgumentNullException("processes");
            _requirements = requirements != null ? requirements.ToList() : throw new ArgumentNullException("requirements");
            _initialFeeSchedule = initialFees != null ? initialFees.ToList() : throw new ArgumentNullException("initialFees");
            _eligibleContexts = contexts != null ? contexts.ToList() : throw new ArgumentNullException("contexts");
        }      
    }
}
