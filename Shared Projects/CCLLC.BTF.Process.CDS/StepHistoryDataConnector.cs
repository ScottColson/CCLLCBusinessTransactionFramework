﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using CCLLC.CDS.Sdk;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core; 

    public class StepHistoryDataConnector : IStepHistoryDataConnector
    {
        public IStepHistory CreateStepHistoryRecord(IDataService dataService, IRecordPointer<Guid> transactionId, IRecordPointer<Guid> processStepId, IRecordPointer<Guid> previousStepHistoryId)
        {
            var stepHistory = new ccllc_stephistory
            {
                ccllc_TransactionId = transactionId?.ToEntityReference(),
                ccllc_ProcessStepId = processStepId?.ToEntityReference(),
                ccllc_PreviousRecordId = previousStepHistoryId?.ToEntityReference(),
                statuscode = ccllc_stephistory_statuscode.Current
            };

            stepHistory.Id = dataService.ToOrgService().Create(stepHistory);

            return stepHistory;           
        }

        public IList<IStepHistory> QueryTransactionStepHistory(IDataService dataService, IRecordPointer<Guid> transactionId)
        {          
            return dataService.ToOrgService().Query<ccllc_stephistory>()
                .SelectAll()
                .WhereAll(e => e
                    .IsActive()
                    .Attribute("ccllc_transactionid").IsEqualTo(transactionId.Id))                    
                .RetrieveAll().ToList<IStepHistory>();
        }

        public IStepHistory UpdateStepHistoryRecord(IDataService dataService, IRecordPointer<Guid> stepHistoryId, IRecordPointer<Guid> nextStepId, IRecordPointer<Guid> agentId, IRecordPointer<Guid> locationId, DateTime? completionDate)
        {
            var stepHistory = new ccllc_stephistory
            {
                Id = stepHistoryId.Id,
                ccllc_NextRecordId = nextStepId?.ToEntityReference(),
                ccllc_CompletedByAgentId = agentId?.ToEntityReference(),
                ccllc_CompletedAtLocationId = locationId?.ToEntityReference(),
                ccllc_CompletedOn = completionDate
            };
           
            dataService.ToOrgService().Update(stepHistory);

            return dataService.ToOrgService().Retrieve(ccllc_stephistory.EntityLogicalName, stepHistoryId.Id, new ColumnSet(true)).ToEntity<ccllc_stephistory>();
        }

        public IStepHistory UpdateStepHistoryStatus(IDataService dataService, IRecordPointer<Guid> stepHistoryId, eProcessStepHistoryStatusEnum status)
        {
            ccllc_stephistory_statuscode? statuscode = null;

            switch (status)
            {
                case eProcessStepHistoryStatusEnum.RolledBack:
                    statuscode = ccllc_stephistory_statuscode.RolledBack;
                    break;
                case eProcessStepHistoryStatusEnum.Current:
                    statuscode = ccllc_stephistory_statuscode.Current;
                    break;
                default:
                    statuscode = ccllc_stephistory_statuscode.Archived;
                    break;
            }

            var stepHistory = new ccllc_stephistory
            {
                Id = stepHistoryId.Id,
                statuscode = statuscode
            };

            dataService.ToOrgService().Update(stepHistory);

            return dataService.ToOrgService().Retrieve(ccllc_stephistory.EntityLogicalName, stepHistoryId.Id, new ColumnSet(true)).ToEntity<ccllc_stephistory>();

        }
    }
}
