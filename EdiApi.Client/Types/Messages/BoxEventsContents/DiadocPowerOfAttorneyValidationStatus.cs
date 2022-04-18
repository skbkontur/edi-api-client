namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Статус проверки МЧД</summary>
    public class DiadocPowerOfAttorneyValidationStatus
    {
        /// <summary>Критичность статуса</summary>
        public DiadocPowerOfAttorneyValidationStatusSeverity Severity { get; set; }

        /// <summary>Идентификатор статуса</summary>
        public DiadocPowerOfAttorneyValidationStatusNamedId StatusNamedId { get; set; }

        /// <summary>Текст статуса</summary>
        public string StatusText { get; set; }

        /// <summary>Ошибки проверки МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusError[] ValidationErrors { get; set; }
    }
}