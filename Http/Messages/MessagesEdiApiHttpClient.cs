using System;
using System.Globalization;
using System.Net;

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
        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetBoxDocumentsSettings")
                .AddParameter("boxId", boxId)
                .ToUri();
            return MakeGetRequest<BoxDocumentsSettings>(url, authToken);
        }

        public InboxMessageEntity GetInboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetInboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<InboxMessageEntity>(url, authToken);
        }

        public OutboxMessageEntity GetOutboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetOutboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<OutboxMessageEntity>(url, authToken);
        }

        public OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "SendMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageFileName", messageData.MessageFileName)
                .ToUri();
            return MakePostRequest<OutboxMessageMeta>(url, authToken, messageData.MessageBody);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        public MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEventsFrom")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        private MessageBoxEventBatch GetEvents(string authToken, UrlBuilder url)
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
    }
}