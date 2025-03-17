#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация о статусе транспортной накладной в Контур.Логистике</summary>
    public class LogisticsWaybillStatusInfo
    {
        /// <summary>Информация об идентификаторах титула транспортой накладной в Контур.Логистике</summary>
        public LogisticsWaybillTitleIdentificationInfo WaybillTitleIdentificationInfo { get; set; } = null!;

        /// <summary>Тип события по транспортной накладной в Контур.Логистике</summary>
        public LogisticsWaybillEventType WaybillEventType { get; set; }

        /// <summary>Статус транспортной накладной</summary>
        public string WaybillStatus { get; set; } = null!;

        /// <summary>Признак черновика. Заполняется в событии TransportationCreated</summary>
        public bool? IsDraft { get; set; }

        /// <summary>Тип титула</summary>
        public string? TitleType { get; set; }

        /// <summary>Идентификатор ящика отправителя в Диадоке. Заполняется в событии TitleForwarded</summary>
        public string? SenderDiadocBoxId { get; set; }

        /// <summary>Идентификатор ящика получателя в Диадоке. Заполняется в событии TitleForwarded</summary>
        public string? RecipientDiadocBoxId { get; set; }

        /// <summary>Результат приёмки. Заполняется в событии ConsigneeTitleSigned</summary>
        public string? AcceptanceResult { get; set; }

        /// <summary>Признак исправления</summary>
        public bool? IsRevision { get; set; }

        /// <summary>Действие с черновиком</summary>
        public string? DraftAction { get; set; }
    }
}