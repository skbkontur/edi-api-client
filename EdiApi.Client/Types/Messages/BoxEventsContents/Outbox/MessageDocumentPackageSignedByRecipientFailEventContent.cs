namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DocumentPackageSignedByRecipientFail</summary>
    public class MessageDocumentPackageSignedByRecipientFailEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Комментарий к отказу в подписи</summary>
        public string Reason { get; set; }

        /// <summary>Необходимо извещение о получение на документ со стороны отправителя</summary>
        public bool NeedReceiptBySender { get; set; }

        /// <summary>Требуется подписать документ отмены фиксации</summary>
        public bool IsGisMtFixationCancellationSigningRequired { get; set; }
    }
}