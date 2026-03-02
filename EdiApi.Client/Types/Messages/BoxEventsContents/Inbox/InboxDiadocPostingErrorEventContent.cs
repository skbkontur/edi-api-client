using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии InboxDiadocPostingError в ящике получателя</summary>
    public class InboxDiadocPostingErrorEventContent : IBoxEventContent
    {
        /// <summary>Метаинформация сообщения</summary>
        public BasicMessageMeta InboxMessageMeta { get; set; }

        /// <summary>Список ошибок, возникших в процессе отправки пакета документов в Диадок</summary>
        public string[] Errors { get; set; }
    }
}