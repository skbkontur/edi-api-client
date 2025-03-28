namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Статус приложенности МЧД к подписи</summary>
    public class DiadocPowerOfAttorneyAttachmentStatus
    {
        /// <summary>Значение статуса</summary>
        public DiadocPowerOfAttorneyAttachmentStatusName StatusName { get; set; }

        /// <summary>Комментарий к статусу, заполняется только для статуса PowerOfAttorneyRequired</summary>
        public string Comment { get; set; }
    }
}