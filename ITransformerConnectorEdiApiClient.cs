using System;

using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IBaseEdiApiClient
    {
        void TakenToTransformation(string authToken, string connectorBoxId, string connectorInteractionId);
        MessageMeta TransformedSuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, MessageData resultMessageData);
        void TransformedUnsuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, string[] errors);
        TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, string exclusiveEventId, uint? count = null);
        TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, DateTime fromDateTime, uint? count = null);
        MessageEntity GetMessage(string authToken, string connectorBoxId, string messageId);
        ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken);
    }
}