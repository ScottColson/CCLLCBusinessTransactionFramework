using System;
using System.Collections.Generic;
using CCLLC.Core;
using CCLLC.BTF.Platform;
using CCLLC.BTF.Revenue;

namespace CCLLC.BTF.Process
{
    /// <summary>
    /// Defines transaction type.
    /// </summary>
    public interface ITransactionType : IRecordPointer<Guid>
    {        
        string Name { get; }
        int DisplayRank { get; }
        ITransactionGroup Group { get; }
        IRecordPointer<Guid> StartUpProcessId { get; }
        ISerializedParameters TransactionDataRecordType { get; }
        IReadOnlyList<string> AffectedRecordTypes { get; }
        IReadOnlyList<ITransactionProcess> AvailableProcesses { get; }
        IReadOnlyList<ITransactionContextType> EligibleContexts { get; }
        IReadOnlyList<IRecordPointer<Guid>> AuthorizedRoles { get; }
        IReadOnlyList<IRecordPointer<Guid>> AuthorizedChannels { get; }
        IReadOnlyList<IRecordPointer<Guid>> InitialFeeSchedule { get; }
        IReadOnlyList<ITransactionRequirement> Requirements { get; }

       
    }
}
