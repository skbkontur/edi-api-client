namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о титуле документа</summary>
    public class DiadocDocumentTitle
    {
        /// <summary>Тип титула документа</summary>
        public DiadocDocumentTitleType DocumentTitleType { get; set; }

        /// <summary>Идентификатор титула документа</summary>
        public string DocumentTitleId { get; set; }

        /// <summary>Информация об отправке титула в роуминг</summary>
        public DiadocRoamingNotification RoamingNotification { get; set; }

        /// <summary>Информация о титуле ЭТрН</summary>
        public DiadocLogisticsWaybillInfo LogisticsWaybillInfo { get; set; }
    }
}