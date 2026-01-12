using System;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;

using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Messages;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;
using Vostok.Tracing.Abstractions;

#nullable enable

namespace SkbKontur.EdiApi.Client.Http.Messages
{
    public class MessagesEdiApiHttpClient : BaseEdiApiHttpClient, IMessagesEdiApiClient
    {
        [Obsolete("Use the constructor overload without apiClientId for OpenID Connect authentication")]
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        [Obsolete("Use the constructor overload without apiClientId for OpenID Connect authentication")]
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        [Obsolete("Use the constructor overload without apiClientId for OpenID Connect authentication")]
        public MessagesEdiApiHttpClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, tracer)
        {
        }

        [Obsolete("Use the constructor overload without apiClientId for OpenID Connect authentication")]
        public MessagesEdiApiHttpClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, tracer)
        {
        }

        public MessagesEdiApiHttpClient(Uri baseUri,
                                        IEdiApiTypesSerializer? serializer = null,
                                        TimeSpan? timeoutInMilliseconds = null,
                                        IWebProxy? proxy = null)
            : base(baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string environment,
                                        IEdiApiTypesSerializer? serializer = null,
                                        TimeSpan? timeoutInMilliseconds = null,
                                        IWebProxy? proxy = null,
                                        ITracer? tracer = null)
            : base(environment, serializer, timeoutInMilliseconds, proxy, tracer)
        {
        }

        public BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId)
        {
            var request = BuildGetBoxDocumentsSettingsRequest(authToken, boxId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponse<BoxDocumentsSettings>(result);
        }

        public async Task<BoxDocumentsSettings> GetBoxDocumentsSettingsAsync(string authToken, string boxId)
        {
            var request = BuildGetBoxDocumentsSettingsRequest(authToken, boxId);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponse<BoxDocumentsSettings>(result);
        }

        public MessageData GetMessage(string authToken, string boxId, string messageId)
        {
            var request = BuildGetMessageRequest(authToken, boxId, messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponse<MessageData>(result);
        }

        public async Task<MessageData> GetMessageAsync(string authToken, string boxId, string messageId)
        {
            var request = BuildGetMessageRequest(authToken, boxId, messageId);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponse<MessageData>(result);
        }

        public InboxMessageMeta GetInboxMessageMeta(string authToken, string boxId, string messageId)
        {
            var request = BuildGetInboxMessageMetaRequest(authToken, boxId, messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponse<InboxMessageMeta>(result);
        }

        public async Task<InboxMessageMeta> GetInboxMessageMetaAsync(string authToken, string boxId, string messageId)
        {
            var request = BuildGetInboxMessageMetaRequest(authToken, boxId, messageId);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponse<InboxMessageMeta>(result);
        }

        public OutboxMessageMeta GetOutboxMessageMeta(string authToken, string boxId, string messageId)
        {
            var request = BuildGetOutboxMessageMetaRequest(authToken, boxId, messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponse<OutboxMessageMeta>(result);
        }

        public async Task<OutboxMessageMeta> GetOutboxMessageMetaAsync(string authToken, string boxId, string messageId)
        {
            var request = BuildGetOutboxMessageMetaRequest(authToken, boxId, messageId);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponse<OutboxMessageMeta>(result);
        }

        public OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData)
        {
            var request = BuildSendMessageRequest(authToken, boxId, messageData);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponse<OutboxMessageMeta>(result);
        }

        public async Task<OutboxMessageMeta> SendMessageAsync(string authToken, string boxId, MessageData messageData)
        {
            var request = BuildSendMessageRequest(authToken, boxId, messageData);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponse<OutboxMessageMeta>(result);
        }

        public void MessageDeliveryStarted(string authToken, string boxId, string messageId)
        {
            var request = BuildMessageDeliveryStartedRequest(authToken, boxId, messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public async Task MessageDeliveryStartedAsync(string authToken, string boxId, string messageId)
        {
            var request = BuildMessageDeliveryStartedRequest(authToken, boxId, messageId);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);
        }

        public void MessageDeliveryFinished(string authToken, string boxId, string messageId, MessageDeliveryResult messageDeliveryResult)
        {
            var request = BuildMessageDeliveryFinishedRequest(authToken, boxId, messageId, messageDeliveryResult);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public async Task MessageDeliveryFinishedAsync(string authToken, string boxId, string messageId, MessageDeliveryResult messageDeliveryResult)
        {
            var request = BuildMessageDeliveryFinishedRequest(authToken, boxId, messageId, messageDeliveryResult);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, string? exclusiveEventId, uint? count = null)
        {
            var request = BuildGetEventsFromExclusiveEventIdRequest(authToken, boxId, exclusiveEventId, count);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponseEvents(result);
        }

        public async Task<MessageBoxEventBatch> GetEventsAsync(string authToken, string boxId, string? exclusiveEventId, uint? count = null)
        {
            var request = BuildGetEventsFromExclusiveEventIdRequest(authToken, boxId, exclusiveEventId, count);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponseEvents(result);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetEventsFromDateTimeRequest(authToken, boxId, fromDateTime, count);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return DeserializeResponseEvents(result);
        }

        public async Task<MessageBoxEventBatch> GetEventsAsync(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetEventsFromDateTimeRequest(authToken, boxId, fromDateTime, count);

            var result = await clusterClient.SendAsync(request).ConfigureAwait(false);
            EnsureSuccessResult(result);

            return DeserializeResponseEvents(result);
        }

        private Request BuildGetBoxDocumentsSettingsRequest(string authToken, string boxId)
        {
            return BuildGetRequest("V1/Messages/GetBoxDocumentsSettings", authToken : authToken)
                .WithAdditionalQueryParameter("boxId", boxId);
        }

        private Request BuildGetMessageRequest(string authToken, string boxId, string messageId)
        {
            return BuildGetRequest("V1/Messages/GetMessage", authToken : authToken)
                   .WithAdditionalQueryParameter("boxId", boxId)
                   .WithAdditionalQueryParameter("messageId", messageId);
        }

        private Request BuildGetInboxMessageMetaRequest(string authToken, string boxId, string messageId)
        {
            return BuildGetRequest("V1/Messages/GetInboxMessageMeta", authToken : authToken)
                   .WithAdditionalQueryParameter("boxId", boxId)
                   .WithAdditionalQueryParameter("messageId", messageId);
        }

        private Request BuildGetOutboxMessageMetaRequest(string authToken, string boxId, string messageId)
        {
            return BuildGetRequest("V1/Messages/GetOutboxMessageMeta", authToken : authToken)
                   .WithAdditionalQueryParameter("boxId", boxId)
                   .WithAdditionalQueryParameter("messageId", messageId);
        }

        private Request BuildSendMessageRequest(string authToken, string boxId, MessageData messageData)
        {
            return BuildPostRequest("V1/Messages/SendMessageExtended", null, authToken, messageData)
                .WithAdditionalQueryParameter("boxId", boxId);
        }

        private Request BuildMessageDeliveryStartedRequest(string authToken, string boxId, string messageId)
        {
            return BuildPostRequest("V1/Messages/MessageDeliveryStarted", authToken : authToken)
                   .WithAdditionalQueryParameter("boxId", boxId)
                   .WithAdditionalQueryParameter("messageId", messageId);
        }

        private Request BuildMessageDeliveryFinishedRequest(string authToken, string boxId, string messageId, MessageDeliveryResult messageDeliveryResult)
        {
            return BuildPostRequest("V1/Messages/MessageDeliveryFinished", null, authToken, messageDeliveryResult)
                   .WithAdditionalQueryParameter("boxId", boxId)
                   .WithAdditionalQueryParameter("messageId", messageId);
        }

        private Request BuildGetEventsFromExclusiveEventIdRequest(string authToken, string boxId, string? exclusiveEventId, uint? count)
        {
            var request = BuildGetRequest("V1/Messages/GetEvents", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("exclusiveEventId", exclusiveEventId);
            return count != null
                       ? request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture))
                       : request;
        }

        private Request BuildGetEventsFromDateTimeRequest(string authToken, string boxId, DateTime fromDateTime, uint? count)
        {
            var request = BuildGetRequest("V1/Messages/GetEventsFrom", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));
            return count != null
                       ? request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture))
                       : request;
        }

        private MessageBoxEventBatch DeserializeResponseEvents(ClusterResult result)
        {
            var boxEventBatch = DeserializeResponse<MessageBoxEventBatch>(result);
            boxEventBatch.Events ??= Array.Empty<MessageBoxEvent>();
            foreach (var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }

            return boxEventBatch;
        }

        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}