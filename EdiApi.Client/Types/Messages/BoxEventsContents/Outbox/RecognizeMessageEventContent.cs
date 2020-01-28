namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public class RecognizeMessageEventContent : OutboxEventContentBase
    {
        public DocumentType DocumentType { get; set; }
        public string SenderPartyId { get; set; }
        public string RecipientPartyId { get; set; }
    }
}