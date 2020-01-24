namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageUndeliveredEventContent : OutboxEventContentBase
    {
        public string[] MessageUndeliveryReasons { get; set; }
    }
}