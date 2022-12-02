namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocRevocationGisMtStatusChanged в ящике получателя</summary>
    public class InboxDiadocRevocationGisMtStatusChanged : InboxDiadocEventContentBase
    {
        /// <summary>Статус в ГИС МТ "Честный знак"</summary>
        public GisMtStatus GisMtStatus { get; set; }

        /// <summary>Список ошибок, которые были получены при взаимодействии с ГИС МТ Честный знак в рамках документооборота</summary>
        public DiadocGisMtStatusDetail[] Details { get; set; }
    }
}