
namespace CCLLC.BTF.Process.CDS
{
    public partial class ccllc_transactiongroup : ITransactionGroup
    {
        public string Name => this.ccllc_name;

        public int DisplayRank => this.ccllc_DisplayRank.HasValue ? this.ccllc_DisplayRank.Value : 0;
    }
}
