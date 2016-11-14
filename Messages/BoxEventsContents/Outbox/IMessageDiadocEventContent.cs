namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public interface IMessageDiadocEventContent
    {
        string DiadocBoxId { get; set; }
        string InvoiceId { get; set; }
        string MessageId { get; set; }
        string Torg12Id { get; set; }
        string InvoiceCorrectionId { get; set; }
        string UniversalTranferDocumentId { get; set; }
        DiadocUrls DiadocUrls { get; set; }
    }
}