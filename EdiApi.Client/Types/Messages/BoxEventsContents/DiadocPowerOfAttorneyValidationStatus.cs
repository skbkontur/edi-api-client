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

        /// <summary>Ошибки проверки МЧД. Устаревшее свойство. Используйте свойства ValidationProtocol и OperationError с более полной информацией о проверке МЧД</summary>
        public DiadocPowerOfAttorneyValidationStatusError[] ValidationErrors { get; set; }

        /// <summary>Протокол валидации с результатами выполнения проверок. Возвращается в случае, когда StatusNamedId принимает значение: IsValid, IsNotValid, HasWarnings</summary>
        public DiadocPowerOfAttorneyValidationProtocol ValidationProtocol { get; set; }

        /// <summary>Описание ошибки, произошедшей в процессе выполнения операции. Возвращается в случае, если StatusNamedId принимает значение ValidationError или CanNotBeValidated</summary>
        public DiadocPowerOfAttorneyValidationStatusError OperationError { get; set; }
    }
}