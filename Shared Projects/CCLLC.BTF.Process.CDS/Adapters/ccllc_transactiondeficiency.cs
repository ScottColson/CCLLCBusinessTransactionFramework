using System;


namespace CCLLC.BTF.Process.CDS
{
    using CCLLC.Core;

    public partial class ccllc_transactiondeficiency : IRequirementDeficiencyRecord
    {
        public IRecordPointer<Guid> Requirement => this.ccllc_RequirementId?.ToRecordPointer();

        public IRecordPointer<Guid> WaivedBy => this.ccllc_WaivedById?.ToRecordPointer();

        public DateTime? WaivedOn => this.ccllc_WaivedOn;

        public eDeficiencyStatusEnum Status
        {
            get
            {
                switch (this.statuscode)
                {
                    case ccllc_transactiondeficiency_statuscode.Active:
                        return eDeficiencyStatusEnum.Invalid;
                    case ccllc_transactiondeficiency_statuscode.Waived:
                        return eDeficiencyStatusEnum.Waived;
                    default:
                        return eDeficiencyStatusEnum.Cleared;
                }
            }
        }

        public string RecordType => this.LogicalName;
    }
}
