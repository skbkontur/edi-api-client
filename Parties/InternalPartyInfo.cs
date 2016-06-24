namespace KonturEdi.Api.Types.Parties
{
    public class InternalPartyInfo : PartyInfo
    {
        public string ProviderId { get; set; }
        public TradingPartnerSettings[] TradingPartnerSettings { get; set; }
    }
}