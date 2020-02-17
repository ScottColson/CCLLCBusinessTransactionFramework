using System;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_processstep : IProcessStepRecord
    {
        public string RecordType => this.LogicalName;

        public string Name => this.ccllc_name;

        public IRecordPointer<Guid> TransactionProcessId => this.ccllc_TransactionProcessId?.ToRecordPointer();
        public IRecordPointer<Guid> ProcessStepTypeId => this.ccllc_ProcessStepTypeId?.ToRecordPointer();

        public IRecordPointer<Guid> SubsequentStepId => this.ccllc_SubsequentStepId?.ToRecordPointer();

        public string StepParameters => this.ccllc_StepParameters;
    }
}
