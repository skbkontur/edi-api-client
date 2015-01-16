using System;

using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Organization;
using KonturEdi.Api.Types.Parties;

namespace KonturEdi.Api.Client
{
    public interface IBaseEdiApiClient<out TBoxEventBatch, TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
        where TBoxEventBatch : BoxEventBatch<TBoxEventType, TBoxEvent>
    {
        string Authenticate(string login, string password);
        PartiesInfo GetAccessiblePartiesInfo(string authToken);
        PartyInfo GetPartyInfo(string authToken, string partyId);
        BoxesInfo GetBoxesInfo(string authToken);
        BoxInfo GetMainApiBox(string authToken, string partyId);
        OrganizationsInfo GetOrganizationsInfo(string authToken, string partyId);

        TBoxEventBatch GetEvents(string authToken, string connectorBoxId, string exclusiveEventId, uint? count = null);
        TBoxEventBatch GetEvents(string authToken, string connectorBoxId, DateTime fromDateTime, uint? count = null);
    }
}