#nullable enable

using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация об универсальном сообщении в событии EDI</summary>
    public class DiadocUniversalMessageEventInfo
    {
        /// <summary>Тип титула документа, к которому относится универсальное сообщение</summary>
        public DiadocDocumentTitleType DocumentTitleType { get; set; }

        /// <summary>Идентификатор титула документа, к которому относится универсальное сообщение</summary>
        public string DocumentTitleId { get; set; } = null!;

        /// <summary>Идентификатор универсального сообщения</summary>
        public string UniversalMessageEntityId { get; set; } = null!;

        /// <summary>Признак того, что универсальное сообщение не влияет на документооборот</summary>
        public bool IsOutOfWorkflow { get; set; }

        /// <summary>Группа кодов универсального сообщения</summary>
        public DiadocUniversalMessageCodeGroup CodeGroup { get; set; }

        /// <summary>События из истории универсального сообщения</summary>
        public DiadocUniversalMessageEvent[] Events { get; set; } = new DiadocUniversalMessageEvent[0];
    }
}