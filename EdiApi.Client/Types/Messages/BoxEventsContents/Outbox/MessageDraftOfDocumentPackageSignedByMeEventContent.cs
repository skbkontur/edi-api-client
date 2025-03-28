namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedByMe</summary>
    public class MessageDraftOfDocumentPackageSignedByMeEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>
        ///     Информация о машиночитаемых доверенностях (МЧД), приложенных к подписям отправителя.
        ///     Количество статусов соответствует количеству документов в пакете.
        /// </summary>
        public DiadocSignaturePowerOfAttorneyInfo[] SenderSignaturePowerOfAttorneyInfos { get; set; }
    }
}