namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public class AcceptedRevocationInfo
    {
        public DiadocDocumentType DiadocDocumentType { get; set; }

        public string RevocationReason { get; set; }
    }
}