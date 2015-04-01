namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageCheckingOkEventContent : MessageOutboxEventContent
    {
        public string[] Warnings { get; set; }
    }
}