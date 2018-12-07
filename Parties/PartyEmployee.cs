using SKBKontur.Catalogue.EDI.Domain.Auth;

namespace KonturEdi.Api.Types.Parties
{
    public class PartyEmployee
    {
        public string UserId { get; set; }
        public ExtendedPartyAccessLevel? ExtendedPartyAccessLevel { get; set; }
    }
}