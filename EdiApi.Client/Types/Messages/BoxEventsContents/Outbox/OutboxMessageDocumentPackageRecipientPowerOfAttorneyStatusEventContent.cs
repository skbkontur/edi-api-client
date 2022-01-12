namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class OutboxMessageDocumentPackageRecipientPowerOfAttorneyStatusEventContent : OutboxDiadocEventContentBase
    {
        public DiadocPowerOfAttorneyInfo PowerOfAttorneyInfo { get; set; }
    }
}