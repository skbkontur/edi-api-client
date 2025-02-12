namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    // todo продублировать доку для ивеентов, а не только для Type'ов?
    /// <summary>Информация о событии InboxDiadocDocumentFixationGisMtStatusChangedEventContent в ящике получателя</summary>
    public class InboxDiadocDocumentFixationGisMtStatusChangedEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo GisMtInfo { get; set; }
    }
}