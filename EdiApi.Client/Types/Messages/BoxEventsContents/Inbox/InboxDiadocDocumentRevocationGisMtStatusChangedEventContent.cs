namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocDocumentRevocationGisMtStatusChanged в ящике получателя</summary>
    public class InboxDiadocDocumentRevocationGisMtStatusChangedEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo GisMtInfo { get; set; }
    }
}