using System;

using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client
{
    public class KonturApiXmlSerializer : IKonturApiSerializer
    {
        public string Serialize(object data)
        {
            return XmlSerializer.Serialize(data);
        }

        public T Deserialize<T>(string serializedData) where T : class
        {
            return XmlSerializer.Deserialize<T>(serializedData);
        }

        public object NormalizeDeserializedObjectToType(object obj, Type targetType)
        {
            return obj;
        }

        public string Accept { get { return "application/xml"; } }
    }
}