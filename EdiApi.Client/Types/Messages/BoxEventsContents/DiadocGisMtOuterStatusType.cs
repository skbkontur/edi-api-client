namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Тип статуса обработки в ГИС МТ "Честный ЗНАК"</summary>
    public enum DiadocGisMtOuterStatusType
    {
        /// <summary>Неизвестный тип</summary>
        UnknownStatus = 0,

        /// <summary>Обработка в процессе</summary>
        Normal = 1,

        /// <summary>Обработка завершена успешно</summary>
        Success = 2,

        /// <summary>Тип присваивается промежуточным статусам, на которые требуется обратить внимание пользователя</summary>
        Warning = 3,

        /// <summary>В процессе обработки возникли ошибки</summary>
        Error = 4,
    }
}