using System;
using System.Collections.Generic;


namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionDeficiencies : IReadOnlyList<IRequirementDeficiency>
    {
        IRequirementDeficiency CreateDeficiency(IProcessExecutionContext executionContext, IRequirement requirement);

        void ClearDeficiency(IProcessExecutionContext executionContext, IRequirement requirement);

        IRequirementDeficiency GetCurrentRequirementDeficiency(IRequirement requirement);
    }
}
