namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DraftOfDocumentPackageSignedBySender</summary>
    public class MessageDraftOfDocumentPackageSignedBySenderEventContent : InboxDiadocEventContentBase
    {
        /// <summary>
        ///     Информация о машиночитаемых доверенностях (МЧД), приложенных к подписям отправителя.
        ///     Количество статусов соответствует количеству документов в пакете.
        /// </summary>
        public DiadocSignaturePowerOfAttorneyInfo[] SenderSignaturePowerOfAttorneyInfos { get; set; }
    }
}