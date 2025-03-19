namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedByMe</summary>
    public class MessageDraftOfDocumentPackageSignedByMeEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Статус приложенности МЧД к подписи отправителя</summary>
        public DiadocPowerOfAttorneyAttachmentStatus SenderPowerOfAttorneyAttachmentStatus { get; set; }
    }
}