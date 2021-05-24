using System;

using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Connectors;
using SkbKontur.EdiApi.Client.Types.Connectors.Transformer;

#nullable enable

namespace SkbKontur.EdiApi.Client
{
    public interface ITransformerConnectorEdiApiClient : IBaseEdiApiClient
    {
        void TransformationStarted(string authToken, string connectorBoxId, string connectorInteractionId);

        void TransformationPaused(string authToken, string connectorBoxId, string connectorInteractionId, string? reason);

        void TransformationResumed(string authToken, string connectorBoxId, string connectorInteractionId);

        void TransformationFinished(string authToken, string connectorBoxId, string connectorInteractionId, ConnectorTransformationResult transformationResult);

        TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, string? exclusiveEventId, uint? count = null);

        TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, DateTime fromDateTime, uint? count = null);

        MessageEntity GetMessage(string authToken, string connectorBoxId, string messageId);

        ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken);
    }
}