using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer.EventContents
{
    public class TransformationResumedEventContent : ConnectorBoxEventContent
    {
        public MessageMeta MessageMeta { get; set; }
    }
}