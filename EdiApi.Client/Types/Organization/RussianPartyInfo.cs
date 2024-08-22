namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Реквизиты российской организации или точки доставки/отгрузки</summary>
    public class RussianPartyInfo
    {
        /// <summary>Реквизиты юридического лица</summary>
        public ULInfo ULInfo { get; set; }

        /// <summary>Реквизиты физического лица</summary>
        public IPInfo IPInfo { get; set; }
    }
}