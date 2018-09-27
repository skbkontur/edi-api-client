namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationRequestedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public RevocationInfo RevocationInfo { get; set; }
    }
}