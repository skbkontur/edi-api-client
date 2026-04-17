namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentPostingErrorV2 в ящике отправителя</summary>
    public class OutboxDiadocDocumentPostingErrorEventContentV2 : OutboxDiadocEventContentBaseV2
    {
        /// <summary>Список ошибок</summary>
        public string[] Errors { get; set; }
    }
}