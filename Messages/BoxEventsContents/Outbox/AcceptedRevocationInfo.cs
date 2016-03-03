namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class AcceptedRevocationInfo
    {
        public DiadocDocumentType DiadocDocumentType { get; set; }

        public string RevocationReason { get; set; }
    }
}