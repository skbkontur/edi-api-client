namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Иностранный адрес</summary>
    public class ForeignAddressInfo
    {
        /// <summary>Двухбуквенный код страны, согласно ISO 3166</summary>
        public string CountryCode { get; set; }
        /// <summary>Адрес</summary>
        public string Address { get; set; }
    }
}