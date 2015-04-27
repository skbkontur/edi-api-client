namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageReceivedDiadocRoamingErrorEventContent : MessageDiadocEventContent
    {
        public string Reason { get; set; }
    }
}