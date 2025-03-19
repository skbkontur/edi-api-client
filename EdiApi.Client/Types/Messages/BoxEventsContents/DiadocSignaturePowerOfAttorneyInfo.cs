namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    ///<summary>Информация о МЧД, приложенной к подписи</summary>
    public class DiadocSignaturePowerOfAttorneyInfo
    {
        /// <summary>Идентификатор подписанного документа в пакете документов</summary>
        public string DocumentEntityId { get; set; }

        /// <summary>Статус приложенности МЧД к подписи документа</summary>
        public DiadocPowerOfAttorneyAttachmentStatus AttachmentStatus { get; set; }
    }
}