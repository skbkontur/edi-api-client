namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedBySender</summary>
    public class MessageDraftOfDocumentPackageSignedBySenderEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Статус приложенности МЧД к подписи отправителя</summary>
        public DiadocPowerOfAttorneyAttachmentStatus SenderPowerOfAttorneyAttachmentStatus { get; set; }
    }
}