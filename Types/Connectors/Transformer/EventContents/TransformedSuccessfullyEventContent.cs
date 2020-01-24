using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Connectors.Transformer.EventContents
{
    public class TransformedSuccessfullyEventContent : ConnectorBoxEventContent
    {
        public MessageMeta ResultMessageMeta { get; set; }

        public ServiceMessageMeta ServiceMessageMeta { get; set; }
    }
}