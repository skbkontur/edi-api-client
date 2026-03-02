namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocPostingError в ящике отправителя</summary>
    public class OutboxDiadocPostingErrorEventContent : OutboxEventContentBase
    {
        /// <summary>Список ошибок, возникших в процессе отправки пакета документов в Диадок</summary>
        public string[] Errors { get; set; }
    }
}