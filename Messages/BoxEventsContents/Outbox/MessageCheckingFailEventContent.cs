namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageCheckingFailEventContent : MessageOutboxEventContent
    {
        public string[] Errors { get; set; }
    }
}