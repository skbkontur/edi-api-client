namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDiadocRevocationAcceptedEventContent : MessageDiadocEventContent
    {
        public AcceptedRevocationInfo AcceptedRevocationInfo { get; set; }
    }
}