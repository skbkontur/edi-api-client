using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IConnectorEdiApiClient<TransformerConnectorBoxEventBatch, TransformerConnectorBoxEventType, TransformerConnectorBoxEvent>
    {
        void TakenToTransformation(string authToken, string connectorBoxId, string connectorInteractionId);
        MessageMeta TransformedSuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, MessageData resultMessageData);
        void TransformedUnsuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, string[] errors);
    }
}