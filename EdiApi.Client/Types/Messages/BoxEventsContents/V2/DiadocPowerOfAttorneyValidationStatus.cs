namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о статусе проверки МЧД</summary>
    public class DiadocPowerOfAttorneyValidationStatus
    {
        /// <summary>Критичность статуса проверки МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusSeverity Severity { get; set; }

        /// <summary>Идентификатор статуса проверки МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusNamedId StatusNamedId { get; set; }

        /// <summary>Текст статуса</summary>
        public string StatusText { get; set; }

        /// <summary>Протокол валидации, содержащий результаты выполнения проверок МЧД</summary>
        public DiadocPowerOfAttorneyValidationProtocol ValidationProtocol { get; set; }

        /// <summary>Ошибка проверки статуса МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusError OperationError { get; set; }
    }
}