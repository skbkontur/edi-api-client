namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationRequestedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public AcceptedRevocationInfo RevocationInfo { get; set; }
    }
}