namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class DiadocPowerOfAttorneyInfo
    {
        public string DocumentEntityId { get; set; }
        public string PowerOfAttorneyEntityId { get; set; }
        public string PowerOfAttorneyStatusChangeEntityId { get; set; }
        public DiadocPowerOfAttorneyFullId PowerOfAttorneyFullId { get; set; }
        public DiadocPowerOfAttorneyValidationStatus PowerOfAttorneyValidationStatus { get; set; }
    }
}