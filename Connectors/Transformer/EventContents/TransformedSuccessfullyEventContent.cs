using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Connectors.Transformer.EventContents
{
    public class TransformedSuccessfullyEventContent : ConnectorBoxEventContent
    {
        public MessageMeta ResultMessageMeta { get; set; }
    }
}