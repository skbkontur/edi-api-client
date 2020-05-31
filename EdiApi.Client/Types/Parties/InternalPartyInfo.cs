namespace SkbKontur.EdiApi.Client.Types.Parties
{
    public class InternalPartyInfo : PartyInfo
    {
        public string ProviderPartyId { get; set; }

        //Obsolete: Use BillingAccountId instead. These fields are equivalent and PortalGroupId will be removed in future releases.
        public string PortalGroupId { get; set; }

        public string BillingAccountId { get; set; }
        public bool IsTest { get; set; }
        public TradingPartnerSettings[] TradingPartnerSettings { get; set; }
    }
}