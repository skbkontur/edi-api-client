namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDocumentPackageSignedByRecipientFailEventContent : OutboxDiadocEventContentBase
    {
        public string Reason { get; set; }
    }
}