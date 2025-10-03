using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.Logistics;
using SkbKontur.EdiApi.Client.Types.Organization;
using SkbKontur.EdiApi.Client.Types.Parties;

using PartyInfo = SkbKontur.EdiApi.Client.Types.Parties.PartyInfo;

#nullable enable

namespace SkbKontur.EdiApi.Client
{
    public interface IBaseEdiApiClient
    {
        string Authenticate(string portalSid);

        string Authenticate(string login, string password);

        PartiesInfo GetAccessiblePartiesInfo(string authToken);

        PartyInfo GetPartyInfo(string authToken, string partyId);

        PartyInfo GetPartyInfoByGln(string authToken, string partyGln);

        BoxesInfo GetBoxesInfo(string authToken);

        BoxInfo GetMainApiBox(string authToken, string partyId);

        OrganizationCatalogueInfo GetOrganizationCatalogueInfo(string authToken, string partyId);

        PartyInfo GetPartyInfoByDepartmentGln(string authToken, string departmentGln);

        TransportationDocumentIdentifier GetTransportationDocumentIdentifier(string authToken, string partyId);
    }
}