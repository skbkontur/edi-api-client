using JetBrains.Annotations;

namespace KonturEdi.Api.Types.Parties
{
    public class PartyInfoWithEmployee : PartyInfo
    {
        [CanBeNull]
        public PartyAccessLevel? ExtendedPartyAccessLevel { get; set; }
    }
}