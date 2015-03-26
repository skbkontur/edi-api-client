namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageUndeliveredEventContent : MessageOutboxEventContent
    {
        public string[] MessageUndeliveryReasons { get; set; }
    }
}