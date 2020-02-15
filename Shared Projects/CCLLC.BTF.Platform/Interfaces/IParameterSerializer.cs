namespace CCLLC.BTF.Platform
{
    public interface IParameterSerializer
    {
        ISerializedParameters CreateParamters(string parameterData);
    }
}
