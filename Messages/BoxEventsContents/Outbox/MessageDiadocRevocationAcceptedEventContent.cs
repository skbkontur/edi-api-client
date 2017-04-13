namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationAcceptedEventContent : OutboxDiadocEventContentBase
    {
        public AcceptedRevocationInfo AcceptedRevocationInfo { get; set; }
    }
}