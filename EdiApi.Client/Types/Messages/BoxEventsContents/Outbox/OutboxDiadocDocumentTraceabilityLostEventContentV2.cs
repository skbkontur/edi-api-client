namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentTraceabilityLostV2 в ящике отправителя</summary>
    public class OutboxDiadocDocumentTraceabilityLostEventContentV2 : OutboxDiadocEventContentBaseV2
    {
        /// <summary>Список причин прекращения отслеживания документа в Диадоке</summary>
        public string[] Reasons { get; set; }
    }
}