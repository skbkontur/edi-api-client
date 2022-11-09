namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocDocumentProcessingFailInGisMt в ящике получателя</summary>
    public class InboxDiadocDocumentProcessingFailInGisMtEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Список ошибок, которые были получены в при взаимодействии с внешним сервисом в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}