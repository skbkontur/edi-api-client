using System;
using System.Net;
using System.Text;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.Logistics;
using SkbKontur.EdiApi.Client.Types.Organization;
using SkbKontur.EdiApi.Client.Types.Parties;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;
using Vostok.Tracing.Abstractions;

using PartyInfo = SkbKontur.EdiApi.Client.Types.Parties.PartyInfo;

#nullable enable

namespace SkbKontur.EdiApi.Client.Http
{
    public abstract class BaseEdiApiHttpClient : IBaseEdiApiClient
    {
        protected BaseEdiApiHttpClient(
            string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy? proxy = null)
        {
            this.apiClientId = apiClientId;
            Serializer = serializer;
            clusterClient = ClusterClientFactory.Get(baseUri, timeoutInMilliseconds, proxy);
        }

        protected BaseEdiApiHttpClient(
            string apiClientId, string environment, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy? proxy = null, ITracer? tracer = null)
        {
            this.apiClientId = apiClientId;
            Serializer = serializer;
            clusterClient = ClusterClientFactory.Get(environment, timeoutInMilliseconds, proxy, tracer : tracer);
        }

        public string Authenticate(string portalSid) =>
            DoAuthenticate(new AuthCredentials {PortalSid = portalSid});

        public string Authenticate(string login, string password) =>
            DoAuthenticate(new AuthCredentials {Login = login, Password = password});

        private string DoAuthenticate(AuthCredentials authCredentials)
        {
            var request = BuildPostRequest("V1/Authenticate", authCredentials);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return result.Response.Content.ToString();
        }

        public PartiesInfo GetAccessiblePartiesInfo(string authToken)
        {
            var request = BuildGetRequest("V1/Parties/GetAccessiblePartiesInfo", authToken : authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartiesInfo>(result.Response.Content.ToString());
        }

        public PartyInfo GetPartyInfo(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfo", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        public PartyInfo GetPartyInfoByGln(string authToken, string partyGln)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfoByGln", authToken : authToken)
                .WithAdditionalQueryParameter("partyGln", partyGln);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        public PartyInfo GetPartyInfoByDepartmentGln(string authToken, string departmentGln)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfoByDepartmentGln", authToken : authToken)
                .WithAdditionalQueryParameter("departmentGln", departmentGln);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        public BoxesInfo GetBoxesInfo(string authToken)
        {
            var request = BuildGetRequest("V1/Boxes/GetBoxesInfo", authToken : authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxesInfo>(result.Response.Content.ToString());
        }

        public BoxInfo GetMainApiBox(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Boxes/GetMainApiBox", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxInfo>(result.Response.Content.ToString());
        }

        public OrganizationCatalogueInfo GetOrganizationCatalogueInfo(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Organizations/GetOrganizationCatalogueInfo", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OrganizationCatalogueInfo>(result.Response.Content.ToString());
        }

        public UsersInfo GetUsersInfo(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Users/GetUsersInfo", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<UsersInfo>(result.Response.Content.ToString());
        }

        public TransportationDocumentIdentifier GetTransportationDocumentIdentifier(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Logistics/GetTransportationDocumentIdentifier", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<TransportationDocumentIdentifier>(result.Response.Content.ToString());
        }

        protected IEdiApiTypesSerializer Serializer { get; }

        protected const int DefaultTimeout = 30 * 1000;

        protected virtual Request BuildPostRequest(string relativeUrl, AuthCredentials? authCredentials = null, string? authToken = null)
            => BuildPostRequest(relativeUrl, authCredentials, authToken, Array.Empty<byte>());

        protected virtual Request BuildPostRequest<TContent>(string relativeUrl, AuthCredentials? authCredentials, string? authToken, TContent? content)
            where TContent : class
        {
            var request = Request.Post(relativeUrl)
                                 .WithHeader("Authorization", BuildAuthorizationHeader(authCredentials, authToken))
                                 .WithAcceptHeader(Serializer.ContentType);

            var data = content as byte[];

            if (data == null && content != null)
            {
                data = Encoding.UTF8.GetBytes(Serializer.Serialize(content));
                request = request.WithContentTypeHeader(Serializer.ContentType);
            }

            if (data == null || data.Length == 0)
            {
                request = request.WithHeader("Content", "no");
                data = new byte[] {1};
            }

            request = request.WithContent(data);

            return request;
        }

        protected virtual Request BuildGetRequest(string relativeUrl, AuthCredentials? authCredentials = null, string? authToken = null)
        {
            var request = Request.Get(relativeUrl)
                                 .WithHeader("Authorization", BuildAuthorizationHeader(authCredentials, authToken))
                                 .WithAcceptHeader(Serializer.ContentType);

            return request;
        }

        protected virtual void EnsureSuccessResult(ClusterResult result)
        {
            if (!result.Response.IsSuccessful)
            {
                throw HttpClientException.Create(result);
            }
        }

        private string BuildAuthorizationHeader(AuthCredentials? authCredentials, string? authToken)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("KonturEdiAuth ");
            stringBuilder.Append("konturediauth_api_client_id=" + apiClientId);
            if (!string.IsNullOrEmpty(authToken))
            {
                stringBuilder.Append(",konturediauth_token=" + authToken);
            }
            if (!string.IsNullOrEmpty(authCredentials?.PortalSid))
            {
                stringBuilder.Append("," + $"konturediauth_portalsid={authCredentials!.PortalSid}");
            }
            if (!string.IsNullOrEmpty(authCredentials?.Login))
            {
                stringBuilder.Append("," + $"konturediauth_login={authCredentials!.Login},konturediauth_password={authCredentials.Password}");
            }

            return stringBuilder.ToString();
        }

        protected readonly IClusterClient clusterClient;

        private readonly string apiClientId;
    }
}