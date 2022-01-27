namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class OutboxDiadocDocumentRecipientPowerOfAttorneyStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}