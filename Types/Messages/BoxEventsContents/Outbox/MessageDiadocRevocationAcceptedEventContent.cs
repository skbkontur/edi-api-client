namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationAcceptedEventContent : OutboxDiadocEventContentBase
    {
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}