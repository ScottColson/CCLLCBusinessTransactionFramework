namespace CCLLC.BTF.Revenue
{
    using CCLLC.Core;

    public interface IRevenueSettingsFactory
    {
        IRevenueSettings CreateSettings(ISettingsProvider settingsProvider);
    }
}
