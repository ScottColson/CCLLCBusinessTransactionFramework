﻿using System.Collections.Generic;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Revenue;
using CCLLC.BTF.Documents;

namespace CCLLC.BTF.Process
{
    public interface ITransaction : CCLLC.BTF.Revenue.ITransaction, CCLLC.BTF.Platform.ITransaction
    {      
        ITransactionType TransactionType { get; }     
        IAgent InitiatingAgent { get; }
        ILocation InitiatingLocation { get;}
        ITransactionProcess InitiatingProcess { get; }
        ITransactionProcess CurrentProcess { get; }
        IProcessStep CurrentStep { get; }
        ITransactionContext TransactionContext { get; }
        ITransactionDataRecord DataRecord { get; }
        IReadOnlyList<IRequirementDeficiency> Deficiencies { get; }
        ITransactionFeeList Fees { get; }
        IReadOnlyList<IGeneratedDocument> GeneratedDocuments { get; }
        IReadOnlyList<ICollectedEvidence> CollectedEvidence { get; }
        IReadOnlyList<IDataOfRecord> AffectedRecords { get; }
        ITransactionHistory TransactionHistory { get; }

        bool CanNavigateForward(IWorkSession session);
        bool CanNavigateBackward(IWorkSession session);
        bool CanJumpTo(IWorkSession session, IStepHistory processHistoryStep);
        IProcessStep NavigateForward(IWorkSession session);
        IProcessStep NavigateBackward(IWorkSession session);
        IProcessStep JumpTo(IWorkSession session, IStepHistory processHistoryStep);
    }
}
