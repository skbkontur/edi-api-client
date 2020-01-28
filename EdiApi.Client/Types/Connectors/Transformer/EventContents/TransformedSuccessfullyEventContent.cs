using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Connectors.Transformer.EventContents
{
    public class TransformedSuccessfullyEventContent : ConnectorBoxEventContent
    {
        public MessageMeta ResultMessageMeta { get; set; }

        public ServiceMessageMeta ServiceMessageMeta { get; set; }
    }
}