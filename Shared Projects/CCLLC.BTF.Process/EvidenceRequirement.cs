using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class EvidenceRequirement : Requirement, IEvidenceRequirement
    {
        protected internal EvidenceRequirement(string recordType, Guid id, string name, eRequirementTypeFlags typeFlag, IRecordPointer<Guid> transactionTypeId, ILogicEvaluator evaluator, IEnumerable<IRecordPointer<Guid>> authorizedWaiverRoles) 
            : base(recordType, id, name, typeFlag, transactionTypeId, evaluator, authorizedWaiverRoles)
        {
        }

        public eEvidenceEvaluationMethodEnum EvidenceEvaluationMethod => throw new NotImplementedException();

        public int? WeightThreshold => throw new NotImplementedException();

        public int? MaximumItemCount => throw new NotImplementedException();

        public IReadOnlyList<IComplientEvidence> ComplientEvidence => throw new NotImplementedException();
    }
}
