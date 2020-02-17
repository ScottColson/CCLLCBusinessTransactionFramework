using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Extends <see cref="ITransactionProcess" to include specific requirements related
    /// to evidence collection and evaluation./>
    /// </summary>
    public interface IEvidenceRequirement : ITransactionRequirement
    {
        /// <summary>
        /// The evaluation mode of the evidence.
        /// </summary>
        eEvidenceEvaluationMethodEnum EvidenceEvaluationMethod { get; }

        /// <summary>
        /// The threshold requirement when using weighted evidence evaluation.
        /// </summary>
        int? WeightThreshold { get; }

        /// <summary>
        /// The maximum number of <see cref="IComplientEvidence"/> items that can be
        /// considered when making a weighted evidence evaluation. 
        /// </summary>
        int? MaximumItemCount { get; }

        /// <summary>
        /// Identifies one or more pieces of evidence that may be collected
        /// and combined to meet the specified evidence requirement.
        /// </summary>
        IReadOnlyList<IComplientEvidence> ComplientEvidence { get; }
    }
}
