using System;
using System.Collections.Generic;


namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface ITransactionDeficiencies : IReadOnlyList<IRequirementDeficiency>
    {
        IRequirementDeficiency CreateDeficiency(IProcessExecutionContext executionContext, ITransactionRequirement requirement);

        void RemoveDeficiency(IProcessExecutionContext executionContext, ITransactionRequirement requirement);

        IRequirementDeficiency GetCurrentRequirementDeficiency(ITransactionRequirement requirement);
    }
}
