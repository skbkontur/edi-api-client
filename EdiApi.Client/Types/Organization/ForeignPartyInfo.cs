namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Реквизиты иностранной организации или точки доставки/отгрузки</summary>
    public class ForeignPartyInfo
    {
        /// <summary>Код страны (цифровой по формату ISO 3166-1)</summary>
        public string CountryCode { get; set; }

        /// <summary>Налоговый номер</summary>
        public string Tin { get; set; }

        /// <summary>Название иностранной организации</summary>
        public string Name { get; set; }
    }
}