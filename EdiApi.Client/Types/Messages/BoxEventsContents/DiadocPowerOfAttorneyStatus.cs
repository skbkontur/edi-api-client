namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class DiadocPowerOfAttorneyStatus
    {
        public string Severity { get; set; }
        public string StatusNamedId { get; set; }
        public string StatusText { get; set; }
        public DiadocPowerOfAttorneyStatusDetails[] StatusDetails { get; set; }
    }
}