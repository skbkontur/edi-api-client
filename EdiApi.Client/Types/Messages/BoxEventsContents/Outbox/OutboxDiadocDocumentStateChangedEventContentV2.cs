using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentStateChangedV2 в ящике отправителя</summary>
    public class OutboxDiadocDocumentStateChangedEventContentV2 : OutboxDiadocEventContentBaseV2
    {
        /// <summary>Состояние документа в Диадоке</summary>
        public DiadocDocumentState DocumentState { get; set; }
    }
}