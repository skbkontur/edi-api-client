using System;

namespace KonturEdi.Api.Types.Parties
{
    public class PartiesInfoForUser
    {
        public Guid UserId { get; set; }

        public PartyInfoWithEmployee[] Parties { get; set; }
    }
}