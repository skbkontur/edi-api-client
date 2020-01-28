namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}