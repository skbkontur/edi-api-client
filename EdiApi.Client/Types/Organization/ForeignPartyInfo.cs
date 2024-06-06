namespace SkbKontur.EdiApi.Client.Types.Organization
{
    public class ForeignPartyInfo
    {
        /// <summary>Код страны (цифровой по формату ISO 3166-1)</summary>
        public string CountryCode { get; set; }

        /// <summary>Название иностранной организации</summary>
        public string Name { get; set; }

        /// <summary>Налоговый номер</summary>
        public string Tin { get; set; }
    }
}