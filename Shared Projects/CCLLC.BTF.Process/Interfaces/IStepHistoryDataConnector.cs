using System;
using System.Collections.Generic;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public interface IStepHistoryDataConnector
    {
        IStepHistory CreateStepHistoryRecord(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> processStepId, IRecordPointer<Guid> previousStepHistoryId);
        IStepHistory UpdateStepHistoryRecord(IDataService dataService, IRecordPointer<Guid> stepHistoryId, IRecordPointer<Guid> nextStepId, IRecordPointer<Guid> agentId, IRecordPointer<Guid> locationId, DateTime completionDate);

        IStepHistory UpdateStepHistoryStatus(IDataService dataService, IRecordPointer<Guid> stepHistoryId, eProcessStepHistoryStatusEnum status);

        IList<IStepHistory> QueryTransactionStepHistory(IDataService dataService, IRecordPointer<Guid> transactionId);
    }
}

    
