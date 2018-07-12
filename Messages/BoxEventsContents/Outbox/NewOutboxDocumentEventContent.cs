namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class NewOutboxDocumentEventContent : DocumentEventContent
    {
        public DocumentType DocumentType { get; set; }
    }
}