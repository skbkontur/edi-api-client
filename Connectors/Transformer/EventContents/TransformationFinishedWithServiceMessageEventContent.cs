namespace KonturEdi.Api.Types.Connectors.Transformer.EventContents
{
    public class TransformationFinishedWithServiceMessageEventContent : ConnectorBoxEventContent
    {
        public ConnectorServiceMessageData ServiceMessageData { get; set; }
    }
}
