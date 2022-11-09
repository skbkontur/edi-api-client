namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentProcessingFailInGisMt в ящике получателя</summary>
    public class OutboxDiadocDocumentProcessingFailInGisMtEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Список ошибок, которые были получены в при взаимодействии с внешним сервисом в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}