using System;

namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    class StepHistory : RecordPointer<Guid>, IStepHistory
    {       
        public IRecordPointer<Guid> ProcessStepId { get; set; }

        public eProcessStepHistoryStatusEnum StepStatus { get; set; }

        public int ExecutionOrder { get; set; }

        public IRecordPointer<Guid> TransactionId { get; set; }

        public IRecordPointer<Guid> PreviousStepId { get; set; }

        public IRecordPointer<Guid> NextStepId { get; set; }

        public IRecordPointer<Guid> CompletedById { get; set; }

        public DateTime? CompletedOn { get; set; }

        public IRecordPointer<Guid> CompletedAtId { get; set; }

        protected internal StepHistory() { }

        protected internal StepHistory(IStepHistory copyFrom)
           : base(copyFrom.RecordType,copyFrom.Id)
        {            
            ProcessStepId = copyFrom.ProcessStepId;
            StepStatus = copyFrom.StepStatus;
            TransactionId = copyFrom.TransactionId;
            PreviousStepId = copyFrom.PreviousStepId;
            NextStepId = copyFrom.NextStepId;
            CompletedOn = copyFrom.CompletedOn;
            CompletedById = copyFrom.CompletedById;
            CompletedAtId = copyFrom.CompletedAtId;
        }                
       
    }
}
