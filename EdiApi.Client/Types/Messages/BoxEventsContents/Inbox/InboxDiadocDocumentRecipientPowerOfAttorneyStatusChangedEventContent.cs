namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DiadocDocumentRecipientPowerOfAttorneyStatusChanged в ящике получателя</summary>
    public class InboxDiadocDocumentRecipientPowerOfAttorneyStatusChangedEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация об МЧД и её текущем статусе проверки</summary>
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}