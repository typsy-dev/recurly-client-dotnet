using System;
using RestSharp;
using RestSharp.Serializers;

namespace Recurly
{
    public class FileSerializer : IDeserializer
    {
        public T Deserialize<T>(RestResponse response)
        {
            var binaryFile = new Recurly.Resources.BinaryFile();
            binaryFile.Data = response.RawBytes;
            return (T)Convert.ChangeType(binaryFile, typeof(T));
        }
    }
}
