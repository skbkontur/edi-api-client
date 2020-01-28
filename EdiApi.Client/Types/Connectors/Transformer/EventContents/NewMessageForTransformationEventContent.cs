using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer.EventContents
{
    public class NewMessageForTransformationEventContent : ConnectorBoxEventContent
    {
        public MessageMeta MessageMeta { get; set; }
    }
}