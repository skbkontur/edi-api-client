using System;

using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Client
{
    public interface IBaseEdiApiClient<out TBoxEventBatch, TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
        where TBoxEventBatch : BoxEventBatch<TBoxEventType, TBoxEvent>
    {
        string Authenticate(string login, string password);
        BoxesInfo GetBoxesInfo(string authToken);

        TBoxEventBatch GetEvents(string authToken, string connectorBoxId, string exclusiveEventId, uint? count = null);
        TBoxEventBatch GetEvents(string authToken, string connectorBoxId, DateTime fromDateTime, uint? count = null);
    }
}