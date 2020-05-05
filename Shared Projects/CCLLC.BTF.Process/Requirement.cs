using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class Requirement : RecordPointer<Guid>, IRequirement
    {       
        public string Name { get; }

        public eRequirementTypeFlags TypeFlag { get; }

        public IRecordPointer<Guid> TransactionTypeId { get; }

        public ILogicEvaluator Evaluator { get; }

        public IReadOnlyList<IRecordPointer<Guid>> AuthorizedWaiverRoles { get; }

        protected internal Requirement(string recordType, Guid id, string name, eRequirementTypeFlags? typeFlag, IRecordPointer<Guid> transactionTypeId, ILogicEvaluator evaluator, IEnumerable<IRecordPointer<Guid>> authorizedWaiverRoles)
            : base(recordType,id)
        {
            this.Name = name;
            this.TypeFlag = typeFlag ?? throw new ArgumentNullException("typeFlag is null.");
            this.TransactionTypeId = transactionTypeId ?? throw new ArgumentNullException("transactionTypeId is null.");
            this.Evaluator = evaluator ?? throw new ArgumentNullException("evaluator is null.");
            this.AuthorizedWaiverRoles = authorizedWaiverRoles?.ToList() ?? throw new ArgumentNullException("authorizedWaiverRoles is null.");
        }

        public bool IsAuthorizedToWaive(IAgent agent)
        {
            foreach(var r in AuthorizedWaiverRoles)
            {
                if(agent.Roles.Where(a => a.Id == r.Id).FirstOrDefault() != null) { return true; }
            }

            return false;
        }
    }
}
