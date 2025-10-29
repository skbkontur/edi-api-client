using System;
using System.Globalization;
using System.Net;

using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Connectors;
using SkbKontur.EdiApi.Client.Types.Connectors.Transformer;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;
using Vostok.Tracing.Abstractions;

#nullable enable

namespace SkbKontur.EdiApi.Client.Http.Connectors
{
    public class TransformerConnectorEdiApiClient : BaseEdiApiHttpClient, ITransformerConnectorEdiApiClient
    {
        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, tracer)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, tracer)
        {
        }

        public void TransformationStarted(string authToken, string connectorBoxId, string connectorInteractionId)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationStarted", authToken : authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationPaused(string authToken, string connectorBoxId, string connectorInteractionId, string? reason)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationPaused", null, authToken, reason)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationResumed(string authToken, string connectorBoxId, string connectorInteractionId)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationResumed", authToken : authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void TransformationFinished(string authToken, string connectorBoxId, string connectorInteractionId, ConnectorTransformationResult transformationResult)
        {
            var request = BuildPostRequest("V1/Connectors/Transformers/TransformationFinished", null, authToken, transformationResult)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter(connectorInteractionIdUrlParameterName, connectorInteractionId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, string? exclusiveEventId, uint? count = null)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetEvents", authToken : authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("exclusiveEventId", exclusiveEventId);

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            return GetEventsInternal(request);
        }

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string connectorBoxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetEventsFrom", authToken : authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            return GetEventsInternal(request);
        }

        public MessageEntity GetMessage(string authToken, string connectorBoxId, string messageId)
        {
            var request = BuildGetRequest("V1/Connectors/Transformers/GetMessage", authToken : authToken)
                          .WithAdditionalQueryParameter(boxIdUrlParameterName, connectorBoxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<MessageEntity>(result.Response.Content.ToString());
        }

        public ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken)
        {
            var request = BuildGetRequest("V1/Boxes/GetConnectorBoxesInfo", authToken : authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<ConnectorBoxesInfo>(result.Response.Content.ToString());
        }

        private TransformerConnectorBoxEventBatch GetEventsInternal(Request request)
        {
            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<TransformerConnectorBoxEventBatch>(result.Response.Content.ToString());

            boxEventBatch.Events ??= new TransformerConnectorBoxEvent[0];
            foreach (var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }

            return boxEventBatch;
        }

        private const string boxIdUrlParameterName = "connectorBoxId";
        private const string connectorInteractionIdUrlParameterName = "connectorInteractionId";
        private readonly IBoxEventTypeRegistry<TransformerConnectorBoxEventType> boxEventTypeRegistry = new TransformerConnectorBoxEventTypeRegistry();
    }
}