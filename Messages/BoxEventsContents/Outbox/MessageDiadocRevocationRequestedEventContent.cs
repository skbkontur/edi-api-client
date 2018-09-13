namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationRequestedEventContent : OutboxDiadocEventContentBase
    {
        public AcceptedRevocationInfo RevocationInfo { get; set; }
    }
}