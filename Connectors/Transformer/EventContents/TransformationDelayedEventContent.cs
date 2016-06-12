using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Connectors.Transformer.EventContents
{
    public class TransformationDelayedEventContent : ConnectorBoxEventContent
    {
        public MessageMeta MessageMeta { get; set; }
    }
}