using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IConnectorEdiApiClient<TransformerConnectorBoxEventBatch, TransformerConnectorBoxEventType, TransformerConnectorBoxEvent>
    {
        void TakenToTransformation(string authToken, string boxId, string connectorInteractionId);
        MessageMeta TransformedSuccessfully(string authToken, string boxId, string connectorInteractionId, MessageData resultMessageData);
        void TransformedUnsuccessfully(string authToken, string boxId, string connectorInteractionId, string[] errors);
    }
}