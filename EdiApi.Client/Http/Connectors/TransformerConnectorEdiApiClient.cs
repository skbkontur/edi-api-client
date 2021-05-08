using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Connectors;
using SkbKontur.EdiApi.Client.Types.Connectors.Transformer;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;

namespace SkbKontur.EdiApi.Client.Http.Connectors
{
    public class TransformerConnectorEdiApiClient : BaseEdiApiHttpClient, ITransformerConnectorEdiApiClient
    {
        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public void TransformationStarted([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationStarted", null, authToken, Array.Empty<byte>())
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationPaused([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId, [CanBeNull] string reason)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationPaused", null, authToken, reason)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationResumed([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationResumed", null, authToken, Array.Empty<byte>())
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationFinished([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string connectorInteractionId, [NotNull] ConnectorTransformationResult transformationResult)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationFinished", null, authToken, transformationResult)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        [NotNull]
        public TransformerConnectorBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string connectorBoxId, [CanBeNull] string exclusiveEventId, uint? count = null)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetEvents", null, authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("exclusiveEventId", exclusiveEventId);

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<TransformerConnectorBoxEventBatch>(result.Response.Content.ToString());

            boxEventBatch.Events = boxEventBatch.Events ?? new TransformerConnectorBoxEvent[0];
            foreach (var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }
            return boxEventBatch;
        }

        [NotNull]
        public TransformerConnectorBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string connectorBoxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetEventsFrom", null, authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<TransformerConnectorBoxEventBatch>(result.Response.Content.ToString());

            boxEventBatch.Events = boxEventBatch.Events ?? new TransformerConnectorBoxEvent[0];
            foreach (var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }
            return boxEventBatch;
        }

        [NotNull]
        public MessageEntity GetMessage([NotNull] string authToken, [NotNull] string connectorBoxId, [NotNull] string messageId)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetMessage", null, authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<MessageEntity>(result.Response.Content.ToString());
        }

        [NotNull]
        public ConnectorBoxesInfo GetConnectorBoxesInfo([NotNull] string authToken)
        {
            var request = BuildGetRequest("V1/Boxes/GetConnectorBoxesInfo", null, authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<ConnectorBoxesInfo>(result.Response.Content.ToString());
        }

        private const string boxIdUrlParameterName = "connectorBoxId";
        private const string connectorInteractionIdUrlParameterName = "connectorInteractionId";
        private readonly IBoxEventTypeRegistry<TransformerConnectorBoxEventType> boxEventTypeRegistry = new TransformerConnectorBoxEventTypeRegistry();
    }
}