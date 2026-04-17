namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Участник документооборота</summary>
    public class DiadocDocumentParticipant
    {
        /// <summary>Роль участника в контексте документа</summary>
        public DiadocDocumentParticipantRole DocumentParticipantRole { get; set; }

        /// <summary>Идентификатор ящика</summary>
        public string BoxId { get; set; }
    }
}