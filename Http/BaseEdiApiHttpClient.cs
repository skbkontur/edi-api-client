using System;
using System.Net;
using System.Text;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.Organization;
using KonturEdi.Api.Types.Parties;
using KonturEdi.Api.Types.Serialization;

using SKBKontur.Catalogue.Core.Http.Tracing;

using PartyInfo = KonturEdi.Api.Types.Parties.PartyInfo;

namespace KonturEdi.Api.Client.Http
{
    public abstract class BaseEdiApiHttpClient : IBaseEdiApiClient
    {
        protected BaseEdiApiHttpClient(
            string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy proxy = null)
        {
            this.apiClientId = apiClientId;
            this.baseUri = baseUri;
            this.proxy = proxy;
            this.timeoutInMilliseconds = timeoutInMilliseconds;
            this.serializer = serializer;
        }

        public string Authenticate(string login, string password)
        {
            var url = new UrlBuilder(baseUri, "V1/Authenticate").ToUri();
            return MakePostRequestInternal(url, null, null, webRequest => { webRequest.Headers["Authorization"] += string.Format(",konturediauth_login={0},konturediauth_password={1}", login, password); });
        }

        public PartiesInfo GetAccessiblePartiesInfo(string authToken)
        {
            var url = new UrlBuilder(baseUri, "V1/Parties/GetAccessiblePartiesInfo").ToUri();
            return MakeGetRequest<PartiesInfo>(url, authToken);
        }

        public PartyInfo GetPartyInfo(string authToken, string partyId)
        {
            var url = new UrlBuilder(baseUri, "V1/Parties/GetPartyInfo")
                .AddParameter("partyId", partyId)
                .ToUri();
            return MakeGetRequest<PartyInfo>(url, authToken);
        }

        public BoxesInfo GetBoxesInfo(string authToken)
        {
            var url = new UrlBuilder(baseUri, "V1/Boxes/GetBoxesInfo").ToUri();
            return MakeGetRequest<BoxesInfo>(url, authToken);
        }

        public BoxInfo GetMainApiBox(string authToken, string partyId)
        {
            var url = new UrlBuilder(baseUri, "V1/Boxes/GetMainApiBox")
                .AddParameter("partyId", partyId)
                .ToUri();
            return MakeGetRequest<BoxInfo>(url, authToken);
        }

        public OrganizationCatalogueInfo GetOrganizationCatalogueInfo(string authToken, string partyId)
        {
            var url = new UrlBuilder(baseUri, "V1/Organizations/GetOrganizationCatalogueInfo")
                .AddParameter("partyId", partyId)
                .ToUri();
            return MakeGetRequest<OrganizationCatalogueInfo>(url, authToken);
        }

        public UsersInfo GetUsersInfo(string authToken, string partyId)
        {
            var url = new UrlBuilder(baseUri, "V1/Users/GetUsersInfo")
                .AddParameter("partyId", partyId)
                .ToUri();
            return MakeGetRequest<UsersInfo>(url, authToken);
        }

        protected TResult MakeGetRequest<TResult>(Uri requestUri, string authToken) where TResult : class
        {
            return serializer.Deserialize<TResult>(MakeGetRequestInternal(requestUri, authToken));
        }

        protected TResult MakePostRequest<TResult>(Uri requestUri, string authToken, byte[] content) where TResult : class
        {
            return serializer.Deserialize<TResult>(MakePostRequestInternal(requestUri, authToken, content));
        }

        protected void MakeGetRequest(Uri requestUri, string authToken)
        {
            MakeGetRequestInternal(requestUri, authToken);
        }

        protected void MakePostRequest(Uri requestUri, string authToken, byte[] content)
        {
            MakePostRequestInternal(requestUri, authToken, content);
        }

        protected void MakePostRequest<TRequestBody>(Uri requestUri, string authToken, TRequestBody bodyObject)
            where TRequestBody : class
        {
            MakePostRequestInternal(requestUri, authToken, serializer.Serialize(bodyObject).GetBytes(), req => req.ContentType = serializer.ContentType);
        }

        protected abstract string RelativeUrl { get; }
        protected abstract string BoxIdUrlParameterName { get; }
        protected Uri BaseUri { get { return baseUri; } }
        protected IEdiApiTypesSerializer Serializer { get { return serializer; } }
        protected const int DefaultTimeout = 30 * 1000;

        protected virtual string MakePostRequestInternal(Uri requestUri, string authToken, byte[] content, Action<HttpWebRequest> customizeRequest = null)
        {
            var request = CreateRequest(requestUri, authToken);
            request.Method = "POST";
            if(content == null || content.Length == 0)
            {
                request.Headers.Add("Content", "no");
                content = new byte[] {1};
            }
            request.ContentLength = content.Length;
            if(customizeRequest != null)
                customizeRequest(request);
            using(new ClientSideHttpTraceContext(string.Format("{0}-FIXME", GetType().Name), request))
            {
                try
                {
                    using(var requestStream = request.GetRequestStream())
                        requestStream.Write(content, 0, content.Length);
                    using(var response = request.GetResponse())
                        return response.GetString();
                }
                catch(WebException exception)
                {
                    throw HttpClientException.Create(exception, requestUri);
                }
            }
        }

        protected virtual string MakeGetRequestInternal(Uri requestUri, string authToken)
        {
            var request = CreateRequest(requestUri, authToken);
            request.Method = "GET";
            using(new ClientSideHttpTraceContext(string.Format("{0}-FIXME", GetType().Name), request))
            {
                try
                {
                    using(var response = request.GetResponse())
                        return response.GetString();
                }
                catch(WebException exception)
                {
                    throw HttpClientException.Create(exception, requestUri);
                }
            }
        }

        private HttpWebRequest CreateRequest(Uri requestUri, string authToken)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.AllowAutoRedirect = false;
            request.AllowWriteStreamBuffering = false;
            request.KeepAlive = true;
            request.Proxy = proxy;
            request.ServicePoint.Expect100Continue = false;
            request.ServicePoint.UseNagleAlgorithm = false;
            request.ServicePoint.ConnectionLimit = 128;
            request.Timeout = timeoutInMilliseconds;
            request.Accept = serializer.ContentType;
            request.Headers["Authorization"] = BuildAuthorizationHeader(authToken);
            return request;
        }

        private string BuildAuthorizationHeader(string authToken)
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
    }
}