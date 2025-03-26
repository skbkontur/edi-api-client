namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DocumentPackageSignedByMePartiallyOk</summary>
    public class MessageDocumentPackageSignedByMePartiallyOkEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Статус приложенности МЧД к подписи получателя</summary>
        public DiadocSignaturePowerOfAttorneyInfo PowerOfAttorneyAttachmentStatus { get; set; }
    }
}