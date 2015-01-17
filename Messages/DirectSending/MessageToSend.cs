namespace KonturEdi.Api.Types.Messages.DirectSending
{
    public class MessageToSend
    {
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public bool IsTest { get; set; }
    }
}