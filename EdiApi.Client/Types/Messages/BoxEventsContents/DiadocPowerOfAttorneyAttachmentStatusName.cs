namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public enum DiadocPowerOfAttorneyAttachmentStatusName
    {
        /// <summary>Неизвестный статус</summary>
        Unknown = 0,

        /// <summary>МЧД приложена</summary>
        PowerOfAttorneyAttached = 1,

        /// <summary>МЧД не требуется</summary>
        PowerOfAttorneyNotRequired = 2,

        /// <summary>МЧД требуется</summary>
        PowerOfAttorneyRequired = 3,
    }
}