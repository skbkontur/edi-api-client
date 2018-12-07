namespace KonturEdi.Api.Types.Parties
{
    public class PartyInfoWithEmployees
    {
        public string PartyId { get; set; }
        public string Gln { get; set; }
        public string BillingId { get; set; }
        public PartyEmployee[] Users { get; set; }
    }
}