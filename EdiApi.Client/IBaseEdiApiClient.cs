using System;
using System.Threading.Tasks;

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
        [Obsolete("Use new OpenId Connect authentication scheme")]
        string Authenticate(string portalSid);

        [Obsolete("Use new OpenId Connect authentication scheme")]
        string Authenticate(string login, string password);

        PartiesInfo GetAccessiblePartiesInfo(string authToken);
        Task<PartiesInfo> GetAccessiblePartiesInfoAsync(string authToken);

        PartyInfo GetPartyInfo(string authToken, string partyId);
        Task<PartyInfo> GetPartyInfoAsync(string authToken, string partyId);

        PartyInfo GetPartyInfoByGln(string authToken, string partyGln);
        Task<PartyInfo> GetPartyInfoByGlnAsync(string authToken, string partyGln);

        BoxesInfo GetBoxesInfo(string authToken);
        Task<BoxesInfo> GetBoxesInfoAsync(string authToken);

        BoxInfo GetMainApiBox(string authToken, string partyId);
        Task<BoxInfo> GetMainApiBoxAsync(string authToken, string partyId);

        OrganizationCatalogueInfo GetOrganizationCatalogueInfo(string authToken, string partyId);
        Task<OrganizationCatalogueInfo> GetOrganizationCatalogueInfoAsync(string authToken, string partyId);

        PartyInfo GetPartyInfoByDepartmentGln(string authToken, string departmentGln);
        Task<PartyInfo> GetPartyInfoByDepartmentGlnAsync(string authToken, string departmentGln);

        TransportationDocumentIdentifier GetTransportationDocumentIdentifier(string authToken, string partyId);
        Task<TransportationDocumentIdentifier> GetTransportationDocumentIdentifierAsync(string authToken, string partyId);
    }
}