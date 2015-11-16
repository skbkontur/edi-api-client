using System;

using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IBaseEdiApiClient
    {
        void TakenToTransformation(string authToken, string boxId, string connectorInteractionId);
        MessageMeta TransformedSuccessfully(string authToken, string boxId, string connectorInteractionId, MessageData resultMessageData);
        void TransformedUnsuccessfully(string authToken, string boxId, string connectorInteractionId, string[] errors);
        TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null);
        TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null);
        MessageEntity GetMessage(string authToken, string boxId, string messageId);
        ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken);
    }
}