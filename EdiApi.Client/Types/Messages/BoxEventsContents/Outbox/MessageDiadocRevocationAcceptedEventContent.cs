namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationAcceptedEventContent : OutboxDiadocEventContentBase
    {
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}