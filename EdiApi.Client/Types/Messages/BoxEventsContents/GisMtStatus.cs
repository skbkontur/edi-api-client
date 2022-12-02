namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Статус в ГИС МТ "Честный знак"</summary>
    public enum GisMtStatus
    {
        /// <summary>Неизвестный статус</summary>
        Unknown = 0,

        /// <summary>Отправляется в ГИС МТ Честный ЗНАК</summary>
        SendingInProgress = 1,

        /// <summary>Обрабатывается в ГИС МТ Честный ЗНАК</summary>
        ProcessingInGisMt = 2,

        /// <summary>Обработан в ГИС МТ Честный ЗНАК</summary>
        SuccessProcessedInGisMt = 3,

        /// <summary>Ошибка обработки документа в ГИС МТ Честный ЗНАК</summary>
        ProcessingFailInGisMt = 4,
    }
}