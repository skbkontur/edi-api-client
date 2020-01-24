using System;

namespace SkbKontur.EdiApi.Types.Organization
{
    public class Organization
    {
        public DateTime? OrganizationDate { get; set; }
        public PartyInfo OrganizationInfo { get; set; }
    }
}