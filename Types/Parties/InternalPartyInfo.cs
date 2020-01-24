namespace SkbKontur.EdiApi.Types.Parties
{
    public class InternalPartyInfo : PartyInfo
    {
        public string ProviderPartyId { get; set; }
        public string PortalGroupId { get; set; }
        public TradingPartnerSettings[] TradingPartnerSettings { get; set; }
    }
}