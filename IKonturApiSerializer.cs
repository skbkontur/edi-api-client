using System;

namespace KonturEdi.Api.Client
{
    public interface IKonturApiSerializer
    {
        string Serialize(object data);
        T Deserialize<T>(string serializedData) where T : class;
        object NormalizeDeserializedObjectToType(object obj, Type targetType);
        string Accept { get; }
    }
}