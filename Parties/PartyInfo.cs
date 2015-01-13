using System;

namespace KonturEdi.Api.Types.Parties
{
    public class PartyInfo
    {
        public string Id { get; set; }
        public string Gln { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public PartyType PartyTypeCode { get; set; }
        public string DiadocOrgId { get; set; }
        public DateTime? OrganizationCatalogueUpdateTime { get; set; }
    }
}
