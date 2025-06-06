namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentShipmentFixationCancellationGisMtStatusChangedEventContent в ящике отправителя</summary>
    public class OutboxDiadocDocumentShipmentFixationCancellationGisMtStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo GisMtInfo { get; set; }
    }
}