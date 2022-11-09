namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocRevocationProcessingFailInGisMt в ящике получателя</summary>
    public class OutboxDiadocRevocationProcessingFailInGisMtEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Список ошибок, которые были получены в при взаимодействии с внешним сервисом в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}