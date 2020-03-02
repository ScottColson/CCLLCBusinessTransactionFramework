namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public class RevenueSettingsFactory : IRevenueSettingsFactory
    {
        public IRevenueSettings CreateSettings(ISettingsProvider settingsProvider)
        {
            return new RevenueSettings(settingsProvider);
        }
    }
}
