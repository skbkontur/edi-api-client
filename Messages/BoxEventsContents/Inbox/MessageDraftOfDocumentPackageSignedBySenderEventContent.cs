namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDraftOfDocumentPackageSignedBySenderEventContent : MessageInboxEventContent
    {
        public string DiadocBoxId { get; set; }
        public string InvoiceId { get; set; }
        public string MessageId { get; set; }
        public string Torg12Id { get; set; }
        public DiadocUrls DiadocUrls { get; set; }
    }
}