namespace KonturEdi.Api.Types.Connectors.Transformer.EventContents
{
    public class TransformedUnsuccessfullyEventContent : ConnectorBoxEventContent
    {
        public string[] ErrorMessages { get; set; }
    }
}