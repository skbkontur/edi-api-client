using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace KonturEdi.Api.Types.Serialization
{
    public static class JsonSerializer
    {
        public static string Serialize(object data, bool indented = false)
        {
            return JsonConvert.SerializeObject(data, indented ? Formatting.Indented : Formatting.None, jsonConverters);
        }

        public static T Deserialize<T>(string serializedData)
        {
            return JsonConvert.DeserializeObject<T>(serializedData, jsonConverters);
        }

        public static object Deserialize(JObject jObject, Type type)
        {
            var serializer = Newtonsoft.Json.JsonSerializer.Create(new JsonSerializerSettings
                {
                    Converters = jsonConverters
                });
            return jObject.ToObject(type, serializer);
        }

        private static readonly JsonConverter[] jsonConverters = new JsonConverter[] {new IsoDateTimeConverter(), new JsonEnumConverter(), new JsonBoxSettingsConvertor()};

        private class JsonEnumConverter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
            {
                if(value == null)
                    writer.WriteNull();
                else
                {
                    var @enum = (Enum)value;
                    var stringValue = @enum.ToString();
                    if(char.IsNumber(stringValue[0]) || stringValue[0] == 45)
                        throw new JsonSerializationException(string.Format("Cannot serialize EnumValue '{0}'", stringValue));
                    writer.WriteValue(stringValue);
                }
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
                Type enumType;
                var isNullable = objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>);
                if(isNullable)
                    enumType = Nullable.GetUnderlyingType(objectType);
                else
                    enumType = objectType;
                switch(reader.TokenType)
                {
                case JsonToken.Null:
                    {
                        return isNullable ? null : (object)0;
                    }
                case JsonToken.String:
                    {
                        var stringValue = reader.Value.ToString();
                        Enum enumValue;
                        if(GetEnumParser(enumType).TryParse(stringValue, out enumValue))
                            return enumValue;
                        return isNullable ? null : (object)0;
                    }
                default:
                    throw new JsonSerializationException(string.Format("Unexpected token when parsing enum. Expected String, got {0}.", reader.TokenType));
                }
            }

            public override bool CanConvert(Type objectType)
            {
                if(objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    objectType = Nullable.GetUnderlyingType(objectType);
                return objectType.IsEnum;
            }

            private static EnumParser GetEnumParser(Type enumType)
            {
                if(!enumParserByType.ContainsKey(enumType))
                {
                    lock(enumParserByType)
                    {
                        if(!enumParserByType.ContainsKey(enumType))
                            enumParserByType[enumType] = new EnumParser(enumType);
                    }
                }
                return (EnumParser)enumParserByType[enumType];
            }

            private static readonly Hashtable enumParserByType = new Hashtable();

            private class EnumParser
            {
                public EnumParser(Type type)
                {
                    if(!type.IsEnum)
                        throw new Exception("Type must be Enum");
                    var enumValues = type.GetEnumValues().Cast<Enum>();
                    stringToEnum = enumValues.ToDictionary(enumValue => enumValue.ToString(), StringComparer.InvariantCultureIgnoreCase);
                }

                public bool TryParse(string stringValue, out Enum enumValue)
                {
                    return stringToEnum.TryGetValue(stringValue, out enumValue);
                }

                private readonly Dictionary<string, Enum> stringToEnum;
            }
        }
    }
}