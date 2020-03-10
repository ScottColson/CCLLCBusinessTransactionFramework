namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public interface IPlatformSettingsFactory
    {
        IPlatformSettings CreateSettings(ISettingsProvider settingsProvider);
    }
}
