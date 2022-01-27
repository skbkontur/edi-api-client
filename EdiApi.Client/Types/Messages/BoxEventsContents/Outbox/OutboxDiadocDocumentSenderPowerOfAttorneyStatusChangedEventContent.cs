namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class OutboxDiadocDocumentSenderPowerOfAttorneyStatusChangedEventContent : OutboxDiadocEventContentBase
    {
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}