namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DiadocDocumentSenderPowerOfAttorneyStatusChanged в ящике отправителя</summary>
    public class OutboxDiadocDocumentSenderPowerOfAttorneyStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация об МЧД и её текущем статусе проверки</summary>
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}