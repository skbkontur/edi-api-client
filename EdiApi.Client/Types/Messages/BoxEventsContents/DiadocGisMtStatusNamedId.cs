namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Статус в ГИС МТ "Честный ЗНАК"</summary>
    public enum DiadocGisMtStatusNamedId
    {
        /// <summary>Неизвестный статус</summary>
        Unknown = 0,

        /// <summary>Отправляется в ГИС МТ "Честный ЗНАК"</summary>
        SendingInProgress = 1,

        /// <summary>Обрабатывается в ГИС МТ "Честный ЗНАК"</summary>
        InProcessing = 2,

        /// <summary>Обработан в ГИС МТ "Честный ЗНАК"</summary>
        SuccessProcessed = 3,

        /// <summary>Ошибка обработки документа в ГИС МТ "Честный ЗНАК"</summary>
        ProcessingError = 4,

        /// <summary>Ошибка отправки документа в ГИС МТ</summary>
        GisReceivingError = 5,
    }
}