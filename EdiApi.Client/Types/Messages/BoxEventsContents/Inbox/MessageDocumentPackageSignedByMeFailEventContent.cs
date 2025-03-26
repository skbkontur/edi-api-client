namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DocumentPackageSignedByMeFail</summary>
    public class MessageDocumentPackageSignedByMeFailEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Статус приложенности МЧД к подписи получателя</summary>
        public DiadocSignaturePowerOfAttorneyInfo PowerOfAttorneyAttachmentStatus { get; set; }
    }
}