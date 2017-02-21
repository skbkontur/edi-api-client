using KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageInboxDiadocEventContent : MessageInboxEventContent, IMessageDiadocEventContent
    {
        public string DiadocBoxId { get; set; }
        public string InvoiceId { get; set; }
        public string MessageId { get; set; }
        public string Torg12Id { get; set; }
        public string InvoiceCorrectionId { get; set; }
        public string UniversalTransferDocumentId { get; set; }
        public string UniversalCorrectionDocumentId { get; set; }
        public string PriceListDocumentId { get; set; }
        public DiadocUrls DiadocUrls { get; set; }
    }
}