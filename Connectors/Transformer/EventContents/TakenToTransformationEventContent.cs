using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Connectors.Transformer.EventContents
{
    public class TakenToTransformationEventContent : ConnectorBoxEventContent
    {
        public MessageMeta MessageMeta { get; set; }
    }
}