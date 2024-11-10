namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Результат проверки МЧД</summary>
    public class DiadocPowerOfAttorneyValidationProtocolCheckResult
    {
        /// <summary>Результат выполнения проверки</summary>
        public DiadocPowerOfAttorneyValidationCheckStatus Status { get; set; }

        /// <summary>Текстовый идентификатор проверки</summary>
        public string Name { get; set; }

        /// <summary>Информация об ошибке или предупреждении</summary>
        public DiadocPowerOfAttorneyValidationStatusError Error { get; set; }
    }
}