﻿namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DocumentPackageSignedByMeOk</summary>
    public class MessageDocumentPackageSignedByMeOkEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация о МЧД, приложенной к подписи получателя</summary>
        public DiadocSignaturePowerOfAttorneyInfo RecipientSignaturePowerOfAttorneyInfo { get; set; }
    }
}