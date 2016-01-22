namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocEventContent : MessageOutboxEventContent, IMessageDiadocEventContent
    {
        public string DiadocBoxId { get; set; }
        public string InvoiceId { get; set; }
        public string MessageId { get; set; }
        public string Torg12Id { get; set; }
        public DiadocUrls DiadocUrls { get; set; }
    }
}