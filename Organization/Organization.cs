using System;

namespace KonturEdi.Api.Types.Organization
{
    public class Organization
    {
        public DateTime? OrganizationDate { get; set; }
        public PartyInfo OrganizationInfo { get; set; }
    }
}