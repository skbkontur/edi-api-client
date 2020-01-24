namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationRequestedEventContent : OutboxDiadocEventContentBase
    {
        public RevocationInfo RevocationInfo { get; set; }
    }
}