namespace KonturEdi.Api.Types.Parties
{
    public class InternalPartyInfo : PartyInfo
    {
        public string ProviderPartyId { get; set; }
        public TradingPartnerSettings[] TradingPartnerSettings { get; set; }
    }
}