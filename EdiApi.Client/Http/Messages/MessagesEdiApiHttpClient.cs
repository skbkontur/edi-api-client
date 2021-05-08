using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Messages;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;

namespace SkbKontur.EdiApi.Client.Http.Messages
{
    public class MessagesEdiApiHttpClient : BaseEdiApiHttpClient, IMessagesEdiApiClient
    {
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        [NotNull]
        public BoxDocumentsSettings GetBoxDocumentsSettings([NotNull] string authToken, [NotNull] string boxId)
        {
            var request = BuildGetRequest("V1/Messages/GetBoxDocumentsSettings", null, authToken)
                .WithAdditionalQueryParameter("boxId", boxId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxDocumentsSettings>(result.Response.Content.ToString());
        }

        [NotNull]
        public MessageData GetMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetMessage", null, authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<MessageData>(result.Response.Content.ToString());
        }

        [NotNull]
        public InboxMessageMeta GetInboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetInboxMessageMeta", null, authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<InboxMessageMeta>(result.Response.Content.ToString());
        }

        [NotNull]
        public OutboxMessageMeta GetOutboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var request = BuildGetRequest("V1/Messages/GetOutboxMessageMeta", null, authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OutboxMessageMeta>(result.Response.Content.ToString());
        }

        [NotNull]
        public OutboxMessageMeta SendMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] MessageData messageData)
        {
            var request = BuildPostRequest("V1/Messages/SendMessage", null, authToken, messageData.MessageBody)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageFileName", messageData.MessageFileName);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OutboxMessageMeta>(result.Response.Content.ToString());
        }

        public void MessageDeliveryStarted([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var request = BuildPostRequest("V1/Messages/MessageDeliveryStarted", null, authToken, Array.Empty<byte>())
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void MessageDeliveryFinished([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId, [NotNull] MessageDeliveryResult messageDeliveryResult)
        {
            var request = BuildPostRequest("V1/Messages/MessageDeliveryFinished", null, authToken, messageDeliveryResult)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("messageId", messageId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, string exclusiveEventId, uint? count = null)
        {
            var request = BuildGetRequest("V1/Messages/GetEvents", null, authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("exclusiveEventId", exclusiveEventId);

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<MessageBoxEventBatch>(result.Response.Content.ToString());
            boxEventBatch.Events = boxEventBatch.Events ?? new MessageBoxEvent[0];
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
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, DateTime fromDateTime, uint? count = null)
        {
            var request = BuildGetRequest("V1/Messages/GetEventsFrom", null, authToken)
                          .WithAdditionalQueryParameter("boxId", boxId)
                          .WithAdditionalQueryParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));

            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<MessageBoxEventBatch>(result.Response.Content.ToString());
            boxEventBatch.Events = boxEventBatch.Events ?? new MessageBoxEvent[0];
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