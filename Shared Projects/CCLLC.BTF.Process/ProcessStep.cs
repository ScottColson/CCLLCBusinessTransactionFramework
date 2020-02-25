using System;
using System.Collections.Generic;
using System.Linq;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    public class ProcessStep : RecordPointer<Guid>, IProcessStep
    {
        protected ISerializedParameters Parameters { get; }

        protected IRecordPointer<Guid> SubsequentStepPointer { get; }
      
        public string Name { get; }

        public IRecordPointer<Guid> TransactionProcessPointer { get; }

        public IProcessStepType Type { get; }

        public IReadOnlyList<IChannel> AuthorizedChannels { get; }

        public IReadOnlyList<IStepRequirement> ValidationRequirements { get; }

        public IReadOnlyList<IAlternateBranch> AlternateBranches { get; }       

        protected internal ProcessStep(IRecordPointer<Guid> stepId, string stepName, IRecordPointer<Guid> transactionProcessPointer,  IProcessStepType stepType, ISerializedParameters parameters, IRecordPointer<Guid> subsequentStepPointer, IEnumerable<IAlternateBranch> alternateBranches, IEnumerable<IChannel> authorizedChannels, IEnumerable<IStepRequirement> validationRequirements)
            : base(stepId)
        {            
            this.Name = stepName;
            this.TransactionProcessPointer = transactionProcessPointer;
            this.Type = stepType;
            this.Parameters = parameters;
            this.AlternateBranches = alternateBranches.ToList();
            this.AuthorizedChannels = authorizedChannels.ToList();
            this.ValidationRequirements = validationRequirements.ToList();
            this.SubsequentStepPointer = subsequentStepPointer;
        }
        
        public IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            if (Type.IsUIStep)
            {
                return Type.GetUIPointer(executionContext, transaction, Parameters);
            }

            return null;
        }

        public IStepExecutionResult Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, IRequirementEvaluator requirementEvaluator)
        {
            try
            {
                bool blockProgress = false;
                bool isValid = true;

                //complete any specific implementation for the step type
                Type.Execute(executionContext, transaction, Parameters);

                if (ValidationRequirements.Count > 0)
                {
                    var requirementPointers = ValidationRequirements.Select(r => r.RequirementId).ToList();
                    var deficiencies = requirementEvaluator.Evaluate(executionContext, requirementPointers);

                    if (deficiencies.Count > 0)
                    {
                        isValid = false;

                        //if any validation requirement is configured to block progress and there is a deficiency for that requirement
                        //then the step is blocked.
                        foreach (var r in ValidationRequirements)
                        {
                            if (r.BlockProcessProgress && deficiencies.Where(d => d.Requirement.Id == r.RequirementId.Id).FirstOrDefault() != null)
                            {
                                blockProgress = true;
                            }
                        }
                    }
                }

                var nextStep = getNextStep(executionContext, transaction);

                return new StepExecutionResult
                {
                    StepIsBlocked = blockProgress,
                    StepIsValid = isValid,
                    NextStep = nextStep
                };
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction)
        {
            if (!Type.IsReversable) return false;

            //complete any specific implementation for the step type
            return Type.Rollback(executionContext, transaction, Parameters);
        }

        public bool IsLastStep() => this.SubsequentStepPointer == null;
        
        private IProcessStep getNextStep(IProcessExecutionContext executionContext, ITransaction transaction)
        {
            try
            {
                if (IsLastStep())
                {
                    return null;
                }

                if (Type.IsConditional)
                {
                    executionContext.Trace("Evaluating {0} conditional branches.", this.AlternateBranches.Count);

                    foreach(var branch in this.AlternateBranches.OrderBy(b => b.EvaluationOrder))
                    {
                        var evaluationResult = branch.Evaluate(executionContext, transaction);
                        if(evaluationResult.Result == true)
                        {
                            executionContext.Trace("Selected branch {0}", branch.Name);

                            if(branch.SubsequentStepPointer != null)
                            {
                                var branchStep = transaction.CurrentProcess.ProcessSteps.Where(r => r.Id == branch.SubsequentStepPointer.Id).FirstOrDefault();
                                if (branchStep is null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessNotFound);

                                return branchStep;
                            }

                            break;
                        }
                    }
                }                    

                var nextStep = transaction.CurrentProcess.ProcessSteps.Where(r => r.Id == this.SubsequentStepPointer.Id).FirstOrDefault();
                if (nextStep == null) throw TransactionException.BuildException(TransactionException.ErrorCode.ProcessStepNotFound);

                return nextStep;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
