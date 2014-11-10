using System;
using System.Net;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEvents;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Messages
{
    public class MessagesEdiApiHttpClient : BaseEdiApiHttpClient<MessageBoxEventBatch, MessageBoxEventType, MessageBoxEvent>, IMessagesEdiApiClient
    {
        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public MessagesEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(new MessageBoxEventTypeRegistry(), apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetBoxDocumentsSettings")
                .AddParameter("boxId", boxId)
                .ToUri();
            return MakeGetRequest<BoxDocumentsSettings>(url, authToken);
        }

        public InboxMessageEntity GetInboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetInboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<InboxMessageEntity>(url, authToken);
        }

        public OutboxMessageEntity GetOutboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetOutboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<OutboxMessageEntity>(url, authToken);
        }

        public OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "SendMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageFileName", messageData.MessageFileName)
                .ToUri();
            return MakePostRequest<OutboxMessageMeta>(url, authToken, messageData.MessageBody);
        }

        protected override string RelativeUrl { get { return "V1/Messages/"; } }
    }
}