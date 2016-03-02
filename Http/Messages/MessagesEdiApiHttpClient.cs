using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEvents;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Messages
{
    public class MessagesEdiApiHttpClient : BaseEdiApiHttpClient, IMessagesEdiApiClient
    {
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        [NotNull]
        public BoxDocumentsSettings GetBoxDocumentsSettings([NotNull] string authToken, [NotNull] string boxId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetBoxDocumentsSettings")
                .AddParameter("boxId", boxId)
                .ToUri();
            return MakeGetRequest<BoxDocumentsSettings>(url, authToken);
        }

        [NotNull]
        public MessageData GetMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<MessageData>(url, authToken);
        }

        [NotNull]
        public InboxMessageMeta GetInboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetInboxMessageMeta")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<InboxMessageMeta>(url, authToken);
        }

        [NotNull]
        public OutboxMessageMeta GetOutboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetOutboxMessageMeta")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<OutboxMessageMeta>(url, authToken);
        }

        [NotNull]
        public OutboxMessageMeta SendMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] MessageData messageData)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "SendMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageFileName", messageData.MessageFileName)
                .ToUri();
            return MakePostRequest<OutboxMessageMeta>(url, authToken, messageData.MessageBody);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEventsFrom")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        [NotNull]
        private MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] UrlBuilder url)
        {
            var boxEventBatch = MakeGetRequest<MessageBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new MessageBoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }
            return boxEventBatch;
        }

        private const string relativeUrl = "V1/Messages/";
        private const string boxIdUrlParameterName = "boxId";
        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}