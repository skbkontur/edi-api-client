namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DocumentPackageSignedByRecipientFail</summary>
    public class MessageDocumentPackageSignedByRecipientFailEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Комментарий к отказу в подписи</summary>
        public string Reason { get; set; }
    }
}