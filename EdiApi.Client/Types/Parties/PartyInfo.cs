using System;

namespace SkbKontur.EdiApi.Client.Types.Parties
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
        public bool LicenseAgreementAccepted { get; set; }
    }
}