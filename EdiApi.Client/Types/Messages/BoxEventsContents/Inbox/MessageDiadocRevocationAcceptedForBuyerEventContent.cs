namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : InboxDiadocEventContentBase
    {
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}