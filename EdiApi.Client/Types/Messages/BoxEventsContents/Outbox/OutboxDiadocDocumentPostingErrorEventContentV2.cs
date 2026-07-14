using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии OutboxDiadocDocumentPostingErrorV2 в ящике отправителя</summary>
    public class OutboxDiadocDocumentPostingErrorEventContentV2 : OutboxDiadocEventContentBaseV2
    {
        /// <summary>Тип документа</summary>
        public DiadocDocumentTypeV2 DocumentType { get; set; }

        /// <summary>Тип титула документа</summary>
        public DiadocDocumentTitleType DocumentTitleType { get; set; }

        /// <summary>Список ошибок</summary>
        public string[] Errors { get; set; }
    }
}