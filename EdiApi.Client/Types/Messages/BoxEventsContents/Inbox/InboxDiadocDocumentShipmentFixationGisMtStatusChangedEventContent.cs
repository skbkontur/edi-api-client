namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocDocumentShipmentFixationGisMtStatusChangedEventContent в ящике отправителя</summary>
    public class InboxDiadocDocumentShipmentFixationGisMtStatusChangedEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo GisMtInfo { get; set; }
    }
}