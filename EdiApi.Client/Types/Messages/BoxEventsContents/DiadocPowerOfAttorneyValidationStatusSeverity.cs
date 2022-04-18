namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Критичность статуса проверки МЧД</summary>
    public enum DiadocPowerOfAttorneyValidationStatusSeverity
    {
        /// <summary>Неизвестная критичность</summary>
        UnknownSeverity = 0,

        /// <summary>Действие не требуется</summary>
        Info = 1,

        /// <summary>Действие выполнено успешно</summary>
        Success = 2,

        /// <summary>Действие требуется</summary>
        Warning = 3,

        /// <summary>Отказано в действии</summary>
        Error = 4,
    }
}