using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IConnectorEdiApiClient<TransformerConnectorBoxEventBatch, TransformerConnectorBoxEventType, TransformerConnectorBoxEvent>
    {
        void TakenToTransformation(string authToken, string connectorBoxId, string messageId);
        MessageMeta TransformedSuccessfully(string authToken, string connectorBoxId, string messageId, MessageData resultMessageData);
        void TransformedUnsuccessfully(string authToken, string connectorBoxId, string messageId, string[] errors);
    }
}