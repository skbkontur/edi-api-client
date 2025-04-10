#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Информация о статусе отправки титула транспортной накладной в Контур.Логистику</summary>
    public class LogisticsWaybillTitlePostingStatusInfo
    {
        /// <summary>Статус отправки титула транспортной накладной в Контур.Логистику</summary>
        public LogisticsWaybillTitlePostingStatus WaybillTitlePostingStatus { get; set; }

        /// <summary>Информация об идентификаторах титула транспортной накладной, отправленного в Контур.Логистику. Заполняется для статуса TitlePostedSuccessfully</summary>
        public LogisticsWaybillTitleIdentificationInfo? WaybillTitleIdentificationInfo { get; set; }

        /// <summary>Сообщения, относящиеся к статусу. Заполняется для статуса TitlePostingError</summary>
        public string[]? StatusMessages { get; set; }
    }
}