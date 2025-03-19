namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DocumentPackageSignedByMeOk</summary>
    public class MessageDocumentPackageSignedByMeOkEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Статус приложенности МЧД к подписи отправителя</summary>
        public DiadocPowerOfAttorneyAttachmentStatus SenderPowerOfAttorneyAttachmentStatus { get; set; }

        /// <summary>Статус приложенности МЧД к подписи получателя</summary>
        public DiadocPowerOfAttorneyAttachmentStatus RecipientPowerOfAttorneyAttachmentStatus { get; set; }
    }
}