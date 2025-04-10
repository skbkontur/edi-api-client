#nullable enable

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Статус отправки титула транспортной накладной в Контур.Логистику</summary>
    public enum LogisticsWaybillTitlePostingStatus
    {
        /// <summary>Неизвестно</summary>
        Unknown = 0,

        /// <summary>Титул успешно отправлен</summary>
        TitlePostedSuccessfully = 1,

        /// <summary>Ошибка отправки титула</summary>
        TitlePostingError = 2,
    }
}