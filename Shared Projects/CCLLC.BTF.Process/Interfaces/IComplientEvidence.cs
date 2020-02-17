using System;

namespace CCLLC.BTF.Process
{
    public interface IComplientEvidence
    {
        /// <summary>
        /// The type of evidience being collected or evaluated.
        /// </summary>
        IEvidenceType Type { get; }

        /// <summary>
        /// Defines the maximum allowable age of the collected evidence (e.g. how long ago
        /// it was collected.)
        /// </summary>
        TimeSpan? MaximumAge { get; }

        /// <summary>
        /// The weight that the evidence bears in meeting the evidence threshold 
        /// established by the <see cref="IEvidenceRequirement"/>. Only
        /// applicable if the requirement is using evidence weight as a criteria.
        /// </summary>
        int? Weight { get; }
    }
}
