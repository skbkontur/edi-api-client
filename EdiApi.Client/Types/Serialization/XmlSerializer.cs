using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.Connectors.Transformer;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Serialization
{
    public static class XmlSerializer
    {
        public static string Serialize(object obj)
        {
            if (ReferenceEquals(null, obj))
                return "";
            using (var stream = new MemoryStream())
            using (var xmlWriter = XmlWriter.Create(stream, new XmlWriterSettings {OmitXmlDeclaration = false, Encoding = new UTF8Encoding(false), Indent = true}))
            {
                GetSerializer(obj.GetType()).Serialize(xmlWriter, obj);
                return new UTF8Encoding(false).GetString(stream.ToArray());
            }
        }

        public static T Deserialize<T>(string serializedData) where T : class
        {
            if (string.IsNullOrEmpty(serializedData))
                return null;
            using (var xmlReader = XmlReader.Create(new StringReader(serializedData)))
                return (T)GetSerializer(typeof(T)).Deserialize(xmlReader);
        }

        private static System.Xml.Serialization.XmlSerializer GetSerializer(Type type)
        {
            return serializers.GetOrAdd(type, t => new System.Xml.Serialization.XmlSerializer(t, xmlAttributeOverrides, knownTypes, null, null));
        }

        private static XmlAttributeOverrides MapTypeWithName<TType>(this XmlAttributeOverrides overrides, string elementName)
        {
            overrides.Add(typeof(TType), new XmlAttributes
                {
                    XmlType = new XmlTypeAttribute
                        {
                            TypeName = elementName
                        }
                });
            return overrides;
        }

        private static readonly XmlAttributeOverrides xmlAttributeOverrides = new XmlAttributeOverrides()
                                                                              .MapTypeWithName<MessageBoxEventBatch>("BoxEventBatch") //Для обратной совместимости со старыми клиентами
                                                                              .MapTypeWithName<MessageBoxEvent>("BoxEvent");

        private static readonly Type[] knownTypes =
            new[]
                {
                    new MessageBoxEventTypeRegistry().GetAllTypes(),
                    new TransformerConnectorBoxEventTypeRegistry().GetAllTypes(),
                    new[]
                        {
                            typeof(BoxInfo),
                            typeof(FtpBoxSettings),
                            typeof(As2BoxSettings),
                            typeof(ApiBoxSettings),
                            typeof(ProviderBoxSettings),
                            typeof(WebBoxSettings),
                        }
                }.SelectMany(x => x.ToArray()).ToArray();

        private static readonly ConcurrentDictionary<Type, System.Xml.Serialization.XmlSerializer> serializers = new ConcurrentDictionary<Type, System.Xml.Serialization.XmlSerializer>();
    }
}