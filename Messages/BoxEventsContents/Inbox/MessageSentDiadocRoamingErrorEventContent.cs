namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageSentDiadocRoamingErrorEventContent : InboxDiadocEventContentBase
    {
        public string Reason { get; set; }
    }
}