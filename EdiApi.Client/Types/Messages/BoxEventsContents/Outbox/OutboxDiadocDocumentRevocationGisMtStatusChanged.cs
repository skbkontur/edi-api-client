namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocRevocationGisMtStatusChanged в ящике отправителя</summary>
    public class OutboxDiadocDocumentRevocationGisMtStatusChanged : OutboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo DiadocGisMtInfo { get; set; }
    }
}