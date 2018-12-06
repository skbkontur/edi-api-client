namespace KonturEdi.Api.Types.Parties
{
    public class PartyInfoWithEmployees : PartyInfo
    {
        public PartyEmployee[] PartyEmployees { get; set; }
    }
}