namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии ChildOutboxMessage</summary>
    public class ChildOutboxMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Внутренний идентификатор родительского сообщения</summary>
        public string ParentDocumentCirculationId { get; set; }

        /// <summary>Имя файла сообщения</summary>
        public string MessageFileName { get; set; }
    }
}