using JetBrains.Annotations;

using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.Organization;
using KonturEdi.Api.Types.Parties;

using PartyInfo = KonturEdi.Api.Types.Parties.PartyInfo;

namespace KonturEdi.Api.Client
{
    public interface IBaseEdiApiClient
    {
        [NotNull]
        string Authenticate([NotNull] string portalSid);

        [NotNull]
        string Authenticate([NotNull] string login, [NotNull] string password);

        [NotNull]
        PartiesInfo GetAccessiblePartiesInfo([NotNull] string authToken);

        [NotNull]
        PartyInfo GetPartyInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        PartyInfo GetPartyInfoByGln([NotNull] string authToken, [NotNull] string partyGln);

        [NotNull]
        BoxesInfo GetBoxesInfo([NotNull] string authToken);

        [NotNull]
        BoxInfo GetMainApiBox([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        OrganizationCatalogueInfo GetOrganizationCatalogueInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        PartyInfo GetPartyInfoByDepartmentGln([NotNull] string authToken, [NotNull] string departmentGln);
    }
}