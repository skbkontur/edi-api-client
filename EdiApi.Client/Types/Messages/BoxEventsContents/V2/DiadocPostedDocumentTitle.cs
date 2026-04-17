namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о титуле документа, отправленном в Диадок</summary>
    public class DiadocPostedDocumentTitle
    {
        /// <summary>Идентификатор ящика, в который был отправлен титул документа</summary>
        public string BoxId { get; set; }

        /// <summary>Тип сообщения</summary>
        public DiadocMessageType MessageType { get; set; }

        /// <summary>Идентификатор сообщения</summary>
        public string MessageId { get; set; }

        /// <summary>Тип документа</summary>
        public DiadocDocumentType DocumentType { get; set; }

        /// <summary>Идентификатор документа</summary>
        public string DocumentId { get; set; }

        /// <summary>Тип титула документа</summary>
        public DiadocDocumentTitleType DocumentTitleType { get; set; }

        /// <summary>Идентификатор титула документа</summary>
        public string DocumentTitleId { get; set; }
    }
}