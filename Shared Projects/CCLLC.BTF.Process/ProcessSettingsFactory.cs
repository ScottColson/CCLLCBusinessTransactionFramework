namespace CCLLC.BTF.Process
{
    using CCLLC.Core;

    public class ProcessSettingsFactory : IProcessSettingsFactory
    {
        public IProcessSettings CreateSettings(ISettingsProvider settingsProvider)
        {
            return new ProcessSettings(settingsProvider);
        }
    }
}
