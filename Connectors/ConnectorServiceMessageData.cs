namespace KonturEdi.Api.Types.Connectors
{
    public class ConnectorServiceMessageData
    {
        public string MessageId { get; set; }
        public string MessageDetails { get; set; }
        public string RecipientGln { get; set; }
        public byte[] MessageBody { get; set; }
    }
}
