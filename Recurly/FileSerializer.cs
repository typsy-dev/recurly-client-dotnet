using System;
using RestSharp;
using RestSharp.Serializers;

namespace Recurly
{
    public class FileSerializer : IDeserializer, IRestSerializer, ISerializer
    {
        public ISerializer Serializer => this;

        public IDeserializer Deserializer => this;

        public string[] AcceptedContentTypes => new string[]{"application/pdf" };

        public SupportsContentType SupportsContentType => contentType => contentType.Value.EndsWith("pdf", StringComparison.InvariantCultureIgnoreCase);

        public DataFormat DataFormat => DataFormat.Binary;

        public ContentType ContentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T Deserialize<T>(RestResponse response)
        {
            var binaryFile = new Recurly.Resources.BinaryFile();
            binaryFile.Data = response.RawBytes;
            return (T)Convert.ChangeType(binaryFile, typeof(T));
        }

        public string Serialize(Parameter parameter)
        {
            throw new NotImplementedException();
        }

        public string Serialize(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
