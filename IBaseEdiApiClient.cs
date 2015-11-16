using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.Organization;
using KonturEdi.Api.Types.Parties;
using PartyInfo = KonturEdi.Api.Types.Parties.PartyInfo;

namespace KonturEdi.Api.Client
{
    public interface IBaseEdiApiClient
    {
        string Authenticate(string login, string password);
        PartiesInfo GetAccessiblePartiesInfo(string authToken);
        PartyInfo GetPartyInfo(string authToken, string partyId);
        BoxesInfo GetBoxesInfo(string authToken);
        BoxInfo GetMainApiBox(string authToken, string partyId);
        OrganizationCatalogueInfo GetOrganizationCatalogueInfo(string authToken, string partyId);
    }
}