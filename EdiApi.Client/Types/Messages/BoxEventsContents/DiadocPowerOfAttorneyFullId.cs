namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    /// <summary>Полный идентификатор МЧД</summary>
    public class DiadocPowerOfAttorneyFullId
    {
        /// <summary>ИНН выпустившей МЧД организации</summary>
        public string IssuerInn { get; set; }
        
        /// <summary>Регистрационный номер МЧД</summary>
        public string RegistrationNumber { get; set; }
    }
}