using System;

namespace KonturEdi.Api.Types.Organization
{
    public class OrganizationInfo
    {
        public DateTime? OrganizationDate { get; set; }
        public PartyInformation PartyInformation { get; set; }
    }
}