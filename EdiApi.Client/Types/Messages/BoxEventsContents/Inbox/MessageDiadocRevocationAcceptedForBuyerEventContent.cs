namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DiadocRevocationAcceptedForBuyer в ящике получателя</summary>
    public class MessageDiadocRevocationAcceptedForBuyerEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация об аннулированном документе</summary>
        public RevocationInfo AcceptedRevocationInfo { get; set; }
    }
}