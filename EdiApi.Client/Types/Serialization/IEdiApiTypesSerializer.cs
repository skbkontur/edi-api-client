using System;

namespace SkbKontur.EdiApi.Client.Types.Serialization
{
    public interface IEdiApiTypesSerializer
    {
        string Serialize(object data);
        T Deserialize<T>(string serializedData) where T : class;
        object NormalizeDeserializedObjectToType(object obj, Type targetType);
        string ContentType { get; }
    }
}