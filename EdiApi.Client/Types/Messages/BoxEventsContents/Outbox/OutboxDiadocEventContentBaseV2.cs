namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class OutboxDiadocEventContentBaseV2 : OutboxEventContentBase
    {
        /// <summary>Сквозной идентификатор для отслеживания событий по документу, отправляемому или отправленному в Диадок</summary>
        public string TraceableIdentifier { get; set; }
    }
}