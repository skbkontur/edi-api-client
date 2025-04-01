#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация об идентификаторах титула транспортой накладной в Контур.Логистике</summary>
    public class LogisticsWaybillTitleIdentificationInfo
    {
        /// <summary>Идентификатор ящика в Диадоке, из которого был отправлен титул в Контур.Логистику</summary>
        public string OriginalSenderDiadocBoxId { get; set; } = null!;

        /// <summary>Идентификатор транспортной накладной в Минтранс</summary>
        public string TransportationDocumentId { get; set; } = null!;

        /// <summary>Внутренний идентификатор перевозки в Контур.Логистике</summary>
        public string LogisticsTransportationId { get; set; } = null!;

        /// <summary>Идентификатор черновика в Контур.Логистике</summary>
        public string? LogisticsDraftId { get; set; }

        /// <summary>Идентификатор титула в Контур.Логистике</summary>
        public string? LogisticsTitleId { get; set; }
    }
}