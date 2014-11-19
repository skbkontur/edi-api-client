using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;

namespace KonturEdi.Api.Client
{
    public interface IConnectorEdiApiClient<out TBoxEventBatch, TBoxEventType, TBoxEvent> : IBaseEdiApiClient<TBoxEventBatch, TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
        where TBoxEventBatch : BoxEventBatch<TBoxEventType, TBoxEvent>
    {
        MessageEntity GetMessage(string authToken, string boxId, string messageId);
        ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken);
    }
}