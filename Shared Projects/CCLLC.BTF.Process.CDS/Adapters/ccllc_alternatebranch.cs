using System;
using System.Collections.Generic;
using System.Text;
using CCLLC.Core;

namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_alternatebranch : IAlternateBranchRecord
    {
        public string Name => this.ccllc_name;

        public int EvaluationOrder => this.ccllc_EvaluationOrder ?? 0;

        public IRecordPointer<Guid> ParentStepId => this.ccllc_ParentStepId?.ToRecordPointer();

        public IRecordPointer<Guid> SubsequentStepId => this.ccllc_SubsequentStepId?.ToRecordPointer();

        public IRecordPointer<Guid> EvaluatorTypeId => this.ccllc_EvaluatorTypeId?.ToRecordPointer();

        public string EvaluationParameters => this.ccllc_EvaluationParameters;

        public string RecordType => this.LogicalName;
    }
}
