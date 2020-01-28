using System;

namespace SkbKontur.EdiApi.Types.Serialization
{
    public class XmlEdiApiTypesSerializer : IEdiApiTypesSerializer
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

        public string ContentType { get { return "application/xml"; } }
    }
}