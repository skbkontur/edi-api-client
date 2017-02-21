using KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : MessageInboxDiadocEventContent
    {
        public AcceptedRevocationInfo AcceptedRevocationInfo { get; set; }
    }
}