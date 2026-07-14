using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentPostedV2 в ящике отправителя</summary>
    public class OutboxDiadocDocumentPostedEventContentV2 : OutboxDiadocEventContentBaseV2
    {
        /// <summary>Информация о титуле документа, отправленном в Диадок</summary>
        public DiadocPostedDocumentTitle PostedDocumentTitle { get; set; }
    }
}