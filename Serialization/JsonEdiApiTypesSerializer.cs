using System;

using Newtonsoft.Json.Linq;

namespace KonturEdi.Api.Types.Serialization
{
    public class JsonEdiApiTypesSerializer : IEdiApiTypesSerializer
    {
        public string Serialize(object data)
        {
            return JsonSerializer.Serialize(data);
        }

        public T Deserialize<T>(string serializedData) where T : class
        {
            return JsonSerializer.Deserialize<T>(serializedData);
        }

        public object NormalizeDeserializedObjectToType(object obj, Type targetType)
        {
            if (ReferenceEquals(null, obj))
                return null;
            if (!(obj is JObject))
                throw new NotSupportedException(string.Format("Only JObject is alloweed here. obj.GetType() = {0}, targetType = {1}", obj.GetType(), targetType));
            return JsonSerializer.Deserialize(obj as JObject, targetType);
        }

        public string ContentType { get { return "application/json"; } }
    }
}