using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Defines the process for completing a transaction. Each process
    /// consists of one or more <see cref="IProcessStep"/> records that are
    /// executed in the order defined in the process. 
    /// </summary>
    public interface ITransactionProcess : IRecordPointer<Guid>
    {       
        string Name { get; }

        IRecordPointer<Guid> TransactionTypeId { get; }
        
        Guid InitialStepId { get; }
  
        IReadOnlyList<IProcessStep> ProcessSteps { get; }

        IProcessStep GetInitialStep();
    }
}
