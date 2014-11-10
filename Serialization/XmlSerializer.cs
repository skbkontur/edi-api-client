using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

using KonturEdi.Api.Types.Messages.Boxes;
using KonturEdi.Api.Types.Messages.Events;

namespace KonturEdi.Api.Types.Serialization
{
    public static class XmlSerializer
    {
        public static string Serialize(object obj)
        {
            if(ReferenceEquals(null, obj))
                return "";
            using(var stream = new MemoryStream())
            using(var xmlWriter = XmlWriter.Create(stream, new XmlWriterSettings {OmitXmlDeclaration = false, Encoding = new UTF8Encoding(false), Indent = true}))
            {
                GetSerializer(obj.GetType()).Serialize(xmlWriter, obj);
                return new UTF8Encoding(false).GetString(stream.ToArray());
            }
        }

        public static T Deserialize<T>(string serializedData) where T : class
        {
            if(string.IsNullOrEmpty(serializedData))
                return null;
            using(var xmlReader = XmlReader.Create(new StringReader(serializedData)))
                return (T)GetSerializer(typeof(T)).Deserialize(xmlReader);
        }

        private static System.Xml.Serialization.XmlSerializer GetSerializer(Type type)
        {
            return serializers.GetOrAdd(type, t => new System.Xml.Serialization.XmlSerializer(t, knownTypes.Concat(new []
                {
                    typeof(BoxInfo),
                    typeof(FtpBoxSettings),
                    typeof(As2BoxSettings),
                    typeof(ApiBoxSettings),
                    typeof(ProviderBoxSettings),
                }).ToArray()));
        }

        private static readonly Type[] knownTypes = new BoxEventTypeRegistry().GetAllTypes();

        private static readonly ConcurrentDictionary<Type, System.Xml.Serialization.XmlSerializer> serializers = new ConcurrentDictionary<Type, System.Xml.Serialization.XmlSerializer>();
    }
}