namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentShipmentFixationGisMtStatusChangedEventContent в ящике отправителя</summary>
    public class OutboxDiadocDocumentShipmentFixationGisMtStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo GisMtInfo { get; set; }
    }
}