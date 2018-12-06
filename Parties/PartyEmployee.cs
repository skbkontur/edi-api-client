using System;

using JetBrains.Annotations;

namespace KonturEdi.Api.Types.Parties
{
    public class PartyEmployee
    {
        public Guid UserId { get; set; }

        [CanBeNull]
        public PartyAccessLevel? ExtendedPartyAccessLevel { get; set; }
    }
}