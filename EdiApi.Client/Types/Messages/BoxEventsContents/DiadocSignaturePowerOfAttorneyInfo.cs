namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    ///<summary>Информация о МЧД</summary>
    public class DiadocSignaturePowerOfAttorneyInfo
    {
        /// <summary>Идентификатор подписанного с МЧД документа в пакете документов</summary>
        public string DocumentEntityId { get; set; }

        /// <summary>Статус приложенности МЧД к подписи</summary>
        public DiadocPowerOfAttorneyAttachmentStatus AttachmentStatus { get; set; }
    }
}