using System;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;
using KonturEdi.Api.Types.Connectors.Transformer;

namespace KonturEdi.Api.Client
{
    public interface ITransformerConnectorEdiApiClient : IBaseEdiApiClient
    {
        void TransformationStarted([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId);

        void TransformationPaused([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId, [CanBeNull] string reason);

        void TransformationResumed([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId);

        void TransformationFinished([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId, [NotNull] ConnectorTransformationResult transformationResult);

        [NotNull]
        TransformerConnectorBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string connectorBoxId, [CanBeNull] string exclusiveEventId, uint? count = null);

        [NotNull]
        TransformerConnectorBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string connectorBoxId, DateTime fromDateTime, uint? count = null);

        [NotNull]
        MessageEntity GetMessage([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string messageId);

        [NotNull]
        ConnectorBoxesInfo GetConnectorBoxesInfo([NotNull] string authToken);
    }
}