namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Состояние титула документа по участнику документооборота</summary>
    public class DiadocParticipantTitleState
    {
        /// <summary>Участник документооборота</summary>
        public DiadocDocumentParticipant Participant { get; set; }

        /// <summary>Статус титула документа, относящийся к участнику документооборота</summary>
        public DiadocParticipantTitleStatus Status { get; set; }

        /// <summary>Информация о подписи</summary>
        public DiadocSignature Signature { get; set; }

        /// <summary>Информация о титуле документа</summary>
        public DiadocDocumentTitle Title { get; set; }

        /// <summary>Информация об отклонении подписи</summary>
        public DiadocSignatureRejection Rejection { get; set; }
    }
}