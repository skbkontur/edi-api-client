namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}