namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.V2
{
    /// <summary>Информация о подписи</summary>
    public class DiadocSignature
    {
        /// <summary>Информация об МЧД и её статусе проверки</summary>
        public DiadocSignaturePowerOfAttorney PowerOfAttorney { get; set; }

        /// <summary>Статус приложенности МЧД к подписи</summary>
        public DiadocPowerOfAttorneyAttachmentStatus PowerOfAttorneyAttachmentStatus { get; set; }
    }
}