namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Состояние документа в Диадоке</summary>
    public class DiadocDocumentState
    {
        /// <summary>Список участников документооборота</summary>
        public DiadocDocumentParticipant[] Participants { get; set; }

        /// <summary>Тип сообщения</summary>
        public DiadocMessageType MessageType { get; set; }

        /// <summary>Идентификатор сообщения</summary>
        public string MessageId { get; set; }

        /// <summary>Тип документа</summary>
        public DiadocDocumentTypeV2 DocumentType { get; set; }

        /// <summary>Идентификатор документа</summary>
        public string DocumentId { get; set; }

        /// <summary>Признак удаленного документа</summary>
        public bool IsDeleted { get; set; }

        /// <summary>Список состояний титулов документа по участникам документооборота</summary>
        public DiadocParticipantTitleState[] ParticipantTitleStates { get; set; }
    }
}