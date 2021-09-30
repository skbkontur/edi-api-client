namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии NewOutboxDocument</summary>
    public class NewOutboxDocumentEventContent : DocumentEventContent
    {
        /// <summary>Тип сообщения</summary>
        public DocumentType DocumentType { get; set; }
    }
}