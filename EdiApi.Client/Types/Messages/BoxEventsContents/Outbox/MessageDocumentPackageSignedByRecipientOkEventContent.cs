﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии DocumentPackageSignedByRecipientOk</summary>
    public class MessageDocumentPackageSignedByRecipientOkEventContent : OutboxDiadocEventContentBase
    {
        /// <summary>Необходимо извещение о получение на документ со стороны отправителя</summary>
        public bool NeedReceiptBySender { get; set; }

        /// <summary>Информация о МЧД, приложенной к подписи получателя</summary>
        public DiadocSignaturePowerOfAttorneyInfo RecipientSignaturePowerOfAttorneyInfo { get; set; }
    }
}