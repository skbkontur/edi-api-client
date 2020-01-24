namespace KonturEdi.Api.Types.Connectors
{
    public class ConnectorBoxInfo
    {
        public string Id { get; set; }
        public string PartyId { get; set; }
        public ConnectorBoxSettings BoxSettings { get; set; }
    }

    public class ConnectorBoxSettings
    {
        public string Name { get; set; }
        public ConnectorType ConnectorType { get; set; }
    }

    public enum ConnectorType
    {
        Unknown,
        Router,
        Transformer,
        Transporter,
    }
}