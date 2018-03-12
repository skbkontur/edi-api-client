namespace KonturEdi.Api.Types.Messages.DirectSending
{
    public class MessageDirectlyToTransportSendResult
    {
        public bool Success { get; set; }
        public DirectSendTransportType TransportType { get; set; }
        public AS2SendDetails AS2Details { get; set; }
        public string Error { get; set; }
    }
}