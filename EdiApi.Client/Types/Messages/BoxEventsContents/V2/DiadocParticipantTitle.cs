namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о титуле документа участника документооборота</summary>
    public class DiadocParticipantTitle
    {
        /// <summary>Участник документооборота</summary>
        public DiadocDocumentParticipant Participant { get; set; }

        /// <summary>Статус титула документа, относящийся к участнику документооборота</summary>
        public DiadocParticipantTitleStatus ParticipantTitleStatus { get; set; }

        /// <summary>Тип титула документа</summary>
        public DiadocDocumentTitleType DocumentTitleType { get; set; }

        /// <summary>Идентификатор титула документа</summary>
        public string DocumentTitleId { get; set; }

        /// <summary>Информация о подписи</summary>
        public DiadocSignature Signature { get; set; }

        /// <summary>Информация об отправке титула в роуминг</summary>
        public DiadocRoamingNotification RoamingNotification { get; set; }

        /// <summary>Информация о титуле ЭТрН</summary>
        public DiadocLogisticsWaybillInfo LogisticsWaybillInfo { get; set; }

        /// <summary>Информация о титуле ЭЗЗ</summary>
        public DiadocLogisticsOrderRequestInfo LogisticsOrderRequestInfo { get; set; }
    }
}