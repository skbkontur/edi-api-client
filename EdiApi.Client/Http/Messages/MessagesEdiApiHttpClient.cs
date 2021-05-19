using System;
using System.Globalization;
using System.Net;

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
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy? proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy? proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeout, IWebProxy? proxy = null, ITracer? tracer = null)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, tracer)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy? proxy = null, ITracer? tracer = null)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, tracer)
        {
        }

        public BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId)
        {
            var request = BuildGetRequest("V1/Messages/GetBoxDocumentsSettings", authToken : authToken)
                .WithAdditionalQueryParameter("boxId", boxId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxDocumentsSettings>(result.Response.Content.ToString());
        }

        public MessageData GetMessage(string authToken, string boxId, string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetMessage", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<MessageData>(result.Response.Content.ToString());
        }

        public InboxMessageMeta GetInboxMessageMeta(string authToken, string boxId, string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetInboxMessageMeta", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<InboxMessageMeta>(result.Response.Content.ToString());
        }

        public OutboxMessageMeta GetOutboxMessageMeta(string authToken, string boxId, string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetOutboxMessageMeta", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OutboxMessageMeta>(result.Response.Content.ToString());
        }

        public OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData)
        {
            var request = BuildPostRequest("V1/Messages/SendMessage", null, authToken, messageData.MessageBody)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageFileName", messageData.MessageFileName);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OutboxMessageMeta>(result.Response.Content.ToString());
        }

        public void MessageDeliveryStarted(string authToken, string boxId, string messageId)
        {
            var request = BuildPostRequest("V1/Messages/MessageDeliveryStarted", authToken: authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void MessageDeliveryFinished(string authToken, string boxId, string messageId, MessageDeliveryResult messageDeliveryResult)
        {
            var request = BuildPostRequest("V1/Messages/MessageDeliveryFinished", null, authToken, messageDeliveryResult)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, string? exclusiveEventId, uint? count = null)
        {
            var request = BuildGetRequest("V1/Messages/GetEvents", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("exclusiveEventId", exclusiveEventId);

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            return GetEventsInternal(request);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetRequest("V1/Messages/GetEventsFrom", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            return GetEventsInternal(request);
        }

        private MessageBoxEventBatch GetEventsInternal(Request request)
        {
            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<MessageBoxEventBatch>(result.Response.Content.ToString());
            boxEventBatch.Events ??= new MessageBoxEvent[0];
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