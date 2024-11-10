namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Протокол валидации, содержащий результаты выполнения проверок МЧД</summary>
    public class DiadocPowerOfAttorneyValidationProtocol
    {
        /// <summary>Результаты выполнения проверок МЧД</summary>
        public DiadocPowerOfAttorneyValidationProtocolCheckResult[] CheckResults { get; set; }
    }
}