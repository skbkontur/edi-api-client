namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox
{
    /// <summary>Информация о событии DocumentPackageSignedByMeFail</summary>
    public class MessageDocumentPackageSignedByMeFailEventContent : InboxDiadocEventContentBase
    {
        /// <summary>Информация о МЧД, приложенной к подписи получателя</summary>
        public DiadocSignaturePowerOfAttorneyInfo RecipientSignaturePowerOfAttorneyInfo { get; set; }
    }
}