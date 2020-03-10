using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;

namespace CCLLC.BTF.Process
{
    public class RequirementEvaluator : IRequirementEvaluator
    {
       

        public RequirementEvaluator()
        {
        }

        public IList<IRequirementDeficiency> Evaluate(IProcessExecutionContext executionContext, ITransaction transaction, IList<IRecordPointer<Guid>> requirementPointers)
        {
            var evaluationDeficiencies = new List<IRequirementDeficiency>();

            foreach (var requirementId in requirementPointers)
            {
                var requirement = transaction.TransactionType.Requirements
                    .Where(r => r.Id == requirementId.Id)
                    .FirstOrDefault() ?? throw new Exception("Requirement is not in the list for this transaction");

                var result = requirement.Evaluator.Evaluate(executionContext, transaction);

                var existingDeficiency = transaction.Deficiencies.GetCurrentRequirementDeficiency(requirement);

                if (result.Passed && existingDeficiency != null && existingDeficiency.Status != eDeficiencyStatusEnum.Waived)
                {
                    transaction.Deficiencies.RemoveDeficiency(executionContext, requirement);
                }
                
                if(!result.Passed)
                {
                    if (existingDeficiency == null)
                    {
                        evaluationDeficiencies.Add(
                            transaction.Deficiencies.CreateDeficiency(executionContext, requirement));
                    }
                    else
                    {
                        evaluationDeficiencies.Add(existingDeficiency);
                    }
                }
            }

            return evaluationDeficiencies;
        }
    }
}
