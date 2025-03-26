namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedBySender</summary>
    public class MessageDraftOfDocumentPackageSignedBySenderEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Статусы приложенности МЧД к подписи отправителя</summary>
        public DiadocSignaturePowerOfAttorneyInfo[] PowerOfAttorneyAttachmentStatuses { get; set; }
    }
}