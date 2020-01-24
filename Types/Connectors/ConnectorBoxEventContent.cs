namespace KonturEdi.Api.Types.Connectors
{
    public abstract class ConnectorBoxEventContent
    {
        public string ConnectorInteractionId { get; set; }
        public string DocumentCirculationId { get; set; }
    }
}