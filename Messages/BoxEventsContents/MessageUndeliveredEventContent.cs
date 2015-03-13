namespace KonturEdi.Api.Types.Messages.BoxEventsContents
{
    public class MessageUndeliveredEventContent : MessageOutboxEventContent
    {
        public string[] MessageUndeliveryReasons { get; set; }
    }
}