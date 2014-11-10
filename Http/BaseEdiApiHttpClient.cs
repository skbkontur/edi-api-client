using System;
using System.Globalization;
using System.Net;
using System.Text;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http
{
    public abstract class BaseEdiApiHttpClient<TBoxEventBatch, TBoxEventType, TBoxEvent> : IBaseEdiApiClient<TBoxEventBatch, TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
        where TBoxEventBatch : BoxEventBatch<TBoxEventType, TBoxEvent>
    {
        protected BaseEdiApiHttpClient(
            IBoxEventTypeRegistry<TBoxEventType> boxEventTypeRegistry,
            string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy proxy = null)
        {
            this.boxEventTypeRegistry = boxEventTypeRegistry;
            this.apiClientId = apiClientId;
            this.baseUri = baseUri;
            this.proxy = proxy;
            this.timeoutInMilliseconds = timeoutInMilliseconds;
            this.serializer = serializer;
        }

        public string Authenticate(string login, string password)
        {
            var url = new UrlBuilder(baseUri, "V1/Authenticate").ToUri();
            var request = CreatePostRequest(url, null, null, webRequest => { webRequest.Headers["Authorization"] += string.Format(",konturediauth_login={0},konturediauth_password={1}", login, password); });
            using(var response = GetWebResponse(request))
                return response.GetString();
        }

        public BoxesInfo GetBoxesInfo(string authToken)
        {
            var url = new UrlBuilder(baseUri, "V1/Boxes/GetBoxesInfo").ToUri();
            return MakeGetRequest<BoxesInfo>(url, authToken);
        }

        public virtual TBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(baseUri, RelativeUrl + "GetEvents")
                .AddParameter("boxId", boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<TBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new TBoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
                NormalizeBoxEvent(boxEvent);
            return boxEventBatch;
        }

        public virtual TBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(baseUri, RelativeUrl + "GetEventsFrom")
                .AddParameter("boxId", boxId)
                .AddParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<TBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new TBoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
                NormalizeBoxEvent(boxEvent);
            return boxEventBatch;
        }

        protected TResult MakeGetRequest<TResult>(Uri requestUri, string authToken) where TResult : class
        {
            using(var response = GetWebResponse(CreateGetRequest(requestUri, authToken)))
                return serializer.Deserialize<TResult>(response.GetString());
        }

        protected TResult MakePostRequest<TResult>(Uri requestUri, string authToken, byte[] content) where TResult : class
        {
            using(var response = GetWebResponse(CreatePostRequest(requestUri, authToken, content)))
                return serializer.Deserialize<TResult>(response.GetString());
        }

        protected void MakeGetRequest(Uri requestUri, string authToken)
        {
            using(var response = GetWebResponse(CreateGetRequest(requestUri, authToken)))
                response.GetString();
        }

        protected void MakePostRequest(Uri requestUri, string authToken, byte[] content)
        {
            using(var response = GetWebResponse(CreatePostRequest(requestUri, authToken, content)))
                response.GetString();
        }

        protected void MakePostRequest<TRequestBody>(Uri requestUri, string authToken, TRequestBody bodyObject)
            where TRequestBody : class
        {
            using(var response = GetWebResponse(CreatePostRequest(requestUri, authToken, serializer.Serialize(bodyObject).GetBytes(), req => req.ContentType = serializer.ContentType)))
                response.GetString();
        }

        protected virtual WebResponse GetWebResponse(WebRequest request)
        {
            try
            {
                return request.GetResponse();
            }
            catch(WebException exception)
            {
                throw HttpClientException.Create(exception, request.RequestUri);
            }
        }

        protected abstract string RelativeUrl { get; }

        protected Uri BaseUri { get { return baseUri; } }
        protected IEdiApiTypesSerializer Serializer { get { return serializer; } }
        protected const int DefaultTimeout = 30 * 1000;

        private void NormalizeBoxEvent(TBoxEvent boxEvent)
        {
            boxEvent.EventContent = boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                                        : null;
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
            request.Accept = serializer.ContentType;
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
            request.Accept = serializer.ContentType;
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
        private readonly Uri baseUri;
        private readonly IWebProxy proxy;
        private readonly int timeoutInMilliseconds;
        private readonly IEdiApiTypesSerializer serializer;

        private readonly IBoxEventTypeRegistry<TBoxEventType> boxEventTypeRegistry;
    }
}