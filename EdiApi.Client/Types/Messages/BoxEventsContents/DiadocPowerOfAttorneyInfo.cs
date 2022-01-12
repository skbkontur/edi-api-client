namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class DiadocPowerOfAttorneyInfo
    {
        public string DocumentEntityId { get; set; }
        public string PowerOfAttorneyEntityId { get; set; }
        public DiadocPowerOfAttorneyFullId PowerOfAttorneyFullId { get; set; }
        public DiadocPowerOfAttorneyStatus PowerOfAttorneyStatus { get; set; }
    }
}