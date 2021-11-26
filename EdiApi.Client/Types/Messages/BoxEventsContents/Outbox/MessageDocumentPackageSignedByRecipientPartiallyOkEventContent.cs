namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class MessageDocumentPackageSignedByRecipientPartiallyOkEventContent : OutboxDiadocEventContentBase
    {
        public string Reason { get; set; }
    }
}