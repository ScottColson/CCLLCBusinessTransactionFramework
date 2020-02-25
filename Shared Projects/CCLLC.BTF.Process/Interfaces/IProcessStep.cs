using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Defines a particular step in a <see cref="ITransactionProcess"/>. 
    /// </summary>
    public interface IProcessStep : IRecordPointer<Guid>
    {       
        string Name { get; }
        IRecordPointer<Guid> TransactionProcessPointer { get; }
        IProcessStepType Type { get; }       
        IReadOnlyList<IChannel> AuthorizedChannels { get; }
        IReadOnlyList<IStepRequirement> ValidationRequirements { get; }
        IReadOnlyList<IAlternateBranch> AlternateBranches { get; }

        IUIPointer GetUIPointer(IProcessExecutionContext executionContext, ITransaction transaction);

        bool IsLastStep();

        /// <summary>
        /// Executes any implementation logic associated with the step. Validates the outcome based
        /// on the associated <see cref="ValidationRequirements"/> and return an <see cref="IStepExecutionResult"/>
        /// with information need to evaluate how the transaction process will roll out.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        IStepExecutionResult Execute(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction, IRequirementEvaluator requirementEvaluator);

        /// <summary>
        /// Executes any code that would rollback the particular step if supported and returns true if rollback occurred.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="session"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        bool Rollback(IProcessExecutionContext executionContext, IWorkSession session, ITransaction transaction);
    }
}
