namespace SkbKontur.EdiApi.Client.Types.Connectors.Transformer.EventContents
{
    public class TransformedUnsuccessfullyEventContent : ConnectorBoxEventContent
    {
        public string[] ErrorMessages { get; set; }
    }
}