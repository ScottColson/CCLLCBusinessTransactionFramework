using System;

namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;

    public partial class ccllc_stephistory : IStepHistory
    {
        public string RecordType => this.LogicalName;

        public eProcessStepHistoryStatusEnum StepStatus
        {
            get
            {
                switch (this.statuscode)
                {
                    case ccllc_stephistory_statuscode.Current:
                        return eProcessStepHistoryStatusEnum.Current;
                    case ccllc_stephistory_statuscode.RolledBack:
                        return eProcessStepHistoryStatusEnum.RolledBack;
                    default:
                        return eProcessStepHistoryStatusEnum.Archived;
                }
            }
        }

        public IRecordPointer<Guid> TransactionId => this.ccllc_TransactionId?.ToRecordPointer();

        public IRecordPointer<Guid> PreviousStepId => this.ccllc_PreviousRecordId?.ToRecordPointer();

        public IRecordPointer<Guid> NextStepId
        {
            get => this.ccllc_NextRecordId?.ToRecordPointer();

            set { this.ccllc_NextRecordId = value?.ToEntityReference(); }
        }


        public IRecordPointer<Guid> CompletedById => this.ccllc_CompletedByAgentId?.ToRecordPointer();

        public DateTime? CompletedOn => this.ccllc_CompletedOn;

        public IRecordPointer<Guid> CompletedAtId => this.ccllc_CompletedAtLocationId?.ToRecordPointer();

        public IRecordPointer<Guid> ProcessStepId => this.ccllc_ProcessStepId?.ToRecordPointer();

        public int ExecutionOrder => throw new NotImplementedException();
    }
}
