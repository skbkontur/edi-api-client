namespace KonturEdi.Api.Types.Parties
{
    public class PartyInfoWithEmployee
    {
        public string PartyId { get; set; }
        public string Gln { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string BillingId { get; set; }
        public ExtendedPartyAccessLevel? ExtendedPartyAccessLevel { get; set; }
    }
}