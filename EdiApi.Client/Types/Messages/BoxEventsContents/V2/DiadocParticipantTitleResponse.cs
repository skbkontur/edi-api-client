namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация об ответе участника документооборота на титул документа</summary>
    public class DiadocParticipantTitleResponse
    {
        /// <summary>Участник документооборота</summary>
        public DiadocDocumentParticipant Participant { get; set; }

        /// <summary>Статус титула документа, относящийся к участнику документооборота</summary>
        public DiadocParticipantTitleStatus ParticipantTitleStatus { get; set; }

        /// <summary>Информация о подписи</summary>
        public DiadocSignature Signature { get; set; }

        /// <summary>Информация об отклонении подписи</summary>
        public DiadocSignatureRejection Rejection { get; set; }

        /// <summary>Информация об отправке титула в роуминг</summary>
        public DiadocRoamingNotification RoamingNotification { get; set; }
    }
}