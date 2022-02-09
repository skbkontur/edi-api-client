namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class DiadocPowerOfAttorneyValidationStatus
    {
        public DiadocPowerOfAttorneyValidationStatusSeverity Severity { get; set; }
        public DiadocPowerOfAttorneyValidationStatusNamedId StatusNamedId { get; set; }
        public string StatusText { get; set; }
        public DiadocPowerOfAttorneyValidationStatusError[] ValidationErrors { get; set; }
    }
}