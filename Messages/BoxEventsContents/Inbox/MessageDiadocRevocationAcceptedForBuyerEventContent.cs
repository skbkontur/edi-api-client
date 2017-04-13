namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public AcceptedRevocationInfo AcceptedRevocationInfo { get; set; }
    }
}