namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocDocumentGisMtStatusChanged в ящике получателя</summary>
    public class InboxDiadocDocumentGisMtStatusChanged : InboxDiadocEventContentBase
    {
        /// <summary>Информация о статусе проверки в ГИС МТ "Честный ЗНАК"</summary>
        public DiadocGisMtInfo DiadocGisMtInfo { get; set; }
    }
}