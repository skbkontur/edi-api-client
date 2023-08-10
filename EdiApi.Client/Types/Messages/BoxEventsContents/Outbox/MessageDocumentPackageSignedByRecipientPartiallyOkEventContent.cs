namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DocumentPackageSignedByRecipientPartiallyOk</summary>
    public class MessageDocumentPackageSignedByRecipientPartiallyOkEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Комментарий к подписи с разногласиями</summary>
        public string Reason { get; set; }

        /// <summary>Необходимо извещение о получение на документ со стороны отправителя</summary>
        public bool NeedReceiptBySender { get; set; }
    }
}