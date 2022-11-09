namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocRevocationProcessingFailInGisMt в ящике получателя</summary>
    public class InboxDiadocRevocationProcessingFailInGisMtEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Список ошибок, которые были получены в при взаимодействии с внешним сервисом в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}