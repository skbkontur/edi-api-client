using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer.EventContents
{
    public class TakenToTransformationEventContent : ConnectorBoxEventContent
    {
        public MessageMeta MessageMeta { get; set; }
    }
}