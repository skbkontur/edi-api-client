namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class RecognizeMessageEventContent : MessageOutboxEventContent
    {
        public DocumentType DocumentType { get; set; }
        public string SenderPartyId { get; set; }
        public string RecipientPartyId { get; set; }
    }
}