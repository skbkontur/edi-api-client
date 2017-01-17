namespace KonturEdi.Api.Types.Connectors
{
    public class ServiceMessageData
    {
        public string MessageId { get; set; }
        public string MessageDetails { get; set; }
        public string RecipientGln { get; set; }
        public byte[] MessageBody { get; set; }
    }
}
