namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageReceivedDiadocRoamingErrorEventContent : OutboxDiadocEventContentBase
    {
        public string Reason { get; set; }
    }
}