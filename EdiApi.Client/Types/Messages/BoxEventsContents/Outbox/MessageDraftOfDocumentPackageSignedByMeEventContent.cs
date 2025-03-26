namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedByMe</summary>
    public class MessageDraftOfDocumentPackageSignedByMeEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Статусы приложенности МЧД к подписи отправителя</summary>
        public DiadocSignaturePowerOfAttorneyInfo[] PowerOfAttorneyAttachmentStatuses { get; set; }
    }
}