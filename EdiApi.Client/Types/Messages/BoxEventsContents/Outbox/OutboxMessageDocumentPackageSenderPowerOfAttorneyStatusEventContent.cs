namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class OutboxMessageDocumentPackageSenderPowerOfAttorneyStatusEventContent : OutboxDiadocEventContentBase
    {
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}