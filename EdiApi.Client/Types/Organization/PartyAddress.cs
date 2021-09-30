namespace SkbKontur.EdiApi.Client.Types.Organization
{
    /// <summary>Адрес организации или точки доставки/отгрузки</summary>
    public class PartyAddress
    {
        /// <summary>Российский адрес</summary>
        public RussianAddressInfo RussianAddressInfo { get; set; }
        /// <summary>Иностранный адрес</summary>
        public ForeignAddressInfo ForeignAddressInfo { get; set; }
    }
}