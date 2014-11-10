using System;
using System.Globalization;
using System.Net;
using System.Text;

using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.Boxes;
using KonturEdi.Api.Types.Messages.Events;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client
{
    public class KonturEdiApiHttpClient
    {
        public KonturEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = defaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, timeoutInMilliseconds, new KonturApiJsonSerializer(), proxy)
        {
        }

        public KonturEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds, IKonturApiSerializer serializer, IWebProxy proxy = null)
        {
            this.apiClientId = apiClientId;
            this.baseUri = baseUri;
            this.proxy = proxy;
            this.timeoutInMilliseconds = timeoutInMilliseconds;
            this.serializer = serializer;
            boxEventTypeRegistry = new BoxEventTypeRegistry();
        }

        public string Authenticate(string login, string password)
        {
            var url = new UrlBuilder(baseUri, "V1/Authenticate").ToUri();
            var request = CreatePostRequest(url, null, null, webRequest => { webRequest.Headers["Authorization"] += string.Format(",konturediauth_login={0},konturediauth_password={1}", login, password); });
            using(var response = request.GetWebResponse())
                return response.GetString();
        }

        public InboxMessageEntity GetInboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/GetInboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<InboxMessageEntity>(url, authToken);
        }

        public OutboxMessageEntity GetOutboxMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/GetOutboxMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<OutboxMessageEntity>(url, authToken);
        }

        public BoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/GetEvents")
                .AddParameter("boxId", boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<BoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new BoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
                NormalizeBoxEvent(boxEvent);
            return boxEventBatch;
        }

        public BoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/GetEventsFrom")
                .AddParameter("boxId", boxId)
                .AddParameter("fromDateTime", ApiDateTimeUtils.ToString(fromDateTime));
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<BoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new BoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
                NormalizeBoxEvent(boxEvent);
            return boxEventBatch;
        }

        public OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/SendMessage")
                .AddParameter("boxId", boxId)
                .AddParameter("messageFileName", messageData.MessageFileName)
                .ToUri();
            return MakePostRequest<OutboxMessageMeta>(url, authToken, messageData.MessageBody);
        }

        public BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId)
        {
            var url = new UrlBuilder(baseUri, "V1/Messages/GetBoxDocumentsSettings")
                .AddParameter("boxId", boxId)
                .ToUri();
            return MakeGetRequest<BoxDocumentsSettings>(url, authToken);
        }

        public BoxesInfo GetBoxesInfo(string authToken)
        {
            var url = new UrlBuilder(baseUri, "V1/Boxes/GetBoxesInfo")
                .ToUri();
            return MakeGetRequest<BoxesInfo>(url, authToken);
        }

        protected virtual TResult MakePostRequest<TResult>(Uri requestUri, string authToken, byte[] content) where TResult : class
        {
            using(var response = CreatePostRequest(requestUri, authToken, content).GetWebResponse())
                return serializer.Deserialize<TResult>(response.GetString());
        }

        protected virtual TResult MakeGetRequest<TResult>(Uri requestUri, string authToken) where TResult : class
        {
            using(var response = CreateGetRequest(requestUri, authToken).GetWebResponse())
                return serializer.Deserialize<TResult>(response.GetString());
        }

        protected readonly Uri baseUri;

        private void NormalizeBoxEvent(BoxEvent boxEvent)
        {
            if(boxEvent.EventType == BoxEventType.Unknown)
                boxEvent.EventContent = null;
            else
                boxEvent.EventContent = serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType));
        }

        private HttpWebRequest CreatePostRequest(Uri requestUri, string authToken, byte[] content, Action<HttpWebRequest> customizeRequest = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.AllowAutoRedirect = false;
            request.AllowWriteStreamBuffering = false;
            request.KeepAlive = true;
            request.Proxy = proxy;
            request.ServicePoint.Expect100Continue = false;
            request.ServicePoint.UseNagleAlgorithm = false;
            request.ServicePoint.ConnectionLimit = 128;
            request.Method = "POST";
            request.Timeout = timeoutInMilliseconds;
            request.Accept = serializer.Accept;
            request.Headers["Authorization"] = BuildAuthorization(authToken);
            if(content == null || content.Length == 0)
            {
                request.Headers.Add("Content", "no");
                content = new byte[] {1};
            }
            request.ContentLength = content.Length;
            if(customizeRequest != null)
                customizeRequest(request);
            using(var requestStream = request.GetRequestStream())
                requestStream.Write(content, 0, content.Length);
            return request;
        }

        private HttpWebRequest CreateGetRequest(Uri requestUri, string authToken)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.AllowAutoRedirect = false;
            request.AllowWriteStreamBuffering = false;
            request.KeepAlive = true;
            request.Proxy = proxy;
            request.ServicePoint.Expect100Continue = false;
            request.ServicePoint.UseNagleAlgorithm = false;
            request.ServicePoint.ConnectionLimit = 128;
            request.Method = "GET";
            request.Timeout = timeoutInMilliseconds;
            request.Accept = serializer.Accept;
            request.Headers["Authorization"] = BuildAuthorization(authToken);
            return request;
        }

        private string BuildAuthorization(string authToken)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("KonturEdiAuth ");
            stringBuilder.Append("konturediauth_api_client_id=" + apiClientId);
            if(!string.IsNullOrEmpty(authToken))
                stringBuilder.Append(",konturediauth_token=" + authToken);
            return stringBuilder.ToString();
        }

        private readonly string apiClientId;
        private readonly IWebProxy proxy;
        private readonly int timeoutInMilliseconds;
        private readonly IKonturApiSerializer serializer;
        private readonly BoxEventTypeRegistry boxEventTypeRegistry;
        private const int defaultTimeout = 30 * 1000;
    }
}