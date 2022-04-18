namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocDocumentRecipientPowerOfAttorneyStatusChanged в ящике отправителя</summary>
    public class OutboxDiadocDocumentRecipientPowerOfAttorneyStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об МЧД и её текущем статусе проверки</summary>
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}