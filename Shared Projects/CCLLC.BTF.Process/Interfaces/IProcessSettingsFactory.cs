namespace CCLLC.BTF.Process
{
    using CCLLC.Core; 
    public interface IProcessSettingsFactory
    {
        IProcessSettings CreateSettings(ISettingsProvider settingsProvider);
    }
}
