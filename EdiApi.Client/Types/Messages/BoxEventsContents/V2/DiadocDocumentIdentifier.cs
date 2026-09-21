namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Идентификатор документа в Диадоке</summary>
    public class DiadocDocumentIdentifier
    {
        /// <summary>Идентификатор сообщения</summary>
        public string MessageId { get; set; }

        /// <summary>Идентификатор документа</summary>
        public string DocumentId { get; set; }
    }
}