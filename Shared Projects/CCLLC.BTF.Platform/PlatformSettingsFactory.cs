namespace CCLLC.BTF.Platform
{
    using CCLLC.Core;

    public class PlatformSettingsFactory : IPlatformSettingsFactory
    {
        public IPlatformSettings CreateSettings(ISettingsProvider settingsProvider)
        {
            return new PlatformSettings(settingsProvider);
        }
    }
}
