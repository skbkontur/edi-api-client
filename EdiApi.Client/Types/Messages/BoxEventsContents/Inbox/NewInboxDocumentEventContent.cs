namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии NewInboxDocument</summary>
    public class NewInboxDocumentEventContent : DocumentEventContent
    {
        /// <summary>Тип сообщения</summary>
        public DocumentType DocumentType { get; set; }
    }
}