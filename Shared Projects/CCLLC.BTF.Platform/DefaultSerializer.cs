using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CCLLC.BTF.Platform
{
    public class DefaultSerializer : IParameterSerializer
    {
        public ISerializedParameters CreateParamters(string parameterData)
        {
            try
            {
                if (string.IsNullOrEmpty(parameterData)) { return new SerializedParameters(); }

                //Deserialize using JSON DataContract serializer
                var serializer = new DataContractJsonSerializer(
                    typeof(Dictionary<string, string>), 
                    new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true
                    });

                var stream = new MemoryStream(System.Text.Encoding.ASCII.GetBytes(parameterData));
                var dictionary = (Dictionary<string, string>)serializer.ReadObject(stream);

                return new SerializedParameters(dictionary);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
