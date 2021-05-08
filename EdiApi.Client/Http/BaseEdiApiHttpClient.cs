using System;
using System.Net;
using System.Text;

using JetBrains.Annotations;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.Organization;
using SkbKontur.EdiApi.Client.Types.Parties;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;

using PartyInfo = SkbKontur.EdiApi.Client.Types.Parties.PartyInfo;

namespace SkbKontur.EdiApi.Client.Http
{
    public abstract class BaseEdiApiHttpClient : IBaseEdiApiClient
    {
        protected BaseEdiApiHttpClient(
            string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy proxy = null, bool enableKeepAlive = true)
        {
            this.apiClientId = apiClientId;
            Serializer = serializer;
            clusterClient = ClusterClientFactory.Get(baseUri, timeoutInMilliseconds, proxy, enableKeepAlive);
        }

        protected BaseEdiApiHttpClient(
            string apiClientId, string environment, IEdiApiTypesSerializer serializer,
            int timeoutInMilliseconds, IWebProxy proxy = null, bool enableKeepAlive = true)
        {
            this.apiClientId = apiClientId;
            Serializer = serializer;
            clusterClient = ClusterClientFactory.Get(environment, timeoutInMilliseconds, proxy, enableKeepAlive);
        }

        [NotNull]
        public string Authenticate([NotNull] string portalSid) =>
            DoAuthenticate(new AuthCredentials {PortalSid = portalSid});

        [NotNull]
        public string Authenticate([NotNull] string login, [NotNull] string password) =>
            DoAuthenticate(new AuthCredentials {Login = login, Password = password});

        [NotNull]
        private string DoAuthenticate(AuthCredentials authCredentials)
        {
            var request = BuildPostRequest("V1/Authenticate", authCredentials, null, Array.Empty<byte>());

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return result.Response.Content.ToString();
        }

        [NotNull]
        public PartiesInfo GetAccessiblePartiesInfo([NotNull] string authToken)
        {
            var request = BuildGetRequest("V1/Parties/GetAccessiblePartiesInfo", null, authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartiesInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartyInfo GetPartyInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfo", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartyInfo GetPartyInfoByGln([NotNull] string authToken, [NotNull] string partyGln)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfoByGln", null, authToken)
                .WithAdditionalQueryParameter("partyGln", partyGln);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartyInfo GetPartyInfoByDepartmentGln([NotNull] string authToken, [NotNull] string departmentGln)
        {
            var request = BuildGetRequest("V1/Parties/GetPartyInfoByDepartmentGln", null, authToken)
                .WithAdditionalQueryParameter("departmentGln", departmentGln);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public BoxesInfo GetBoxesInfo([NotNull] string authToken)
        {
            var request = BuildGetRequest("V1/Boxes/GetBoxesInfo", null, authToken);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxesInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public BoxInfo GetMainApiBox([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Boxes/GetMainApiBox", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public OrganizationCatalogueInfo GetOrganizationCatalogueInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Organizations/GetOrganizationCatalogueInfo", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<OrganizationCatalogueInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public UsersInfo GetUsersInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Users/GetUsersInfo", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<UsersInfo>(result.Response.Content.ToString());
        }

        protected Uri BaseUri { get; }
        protected IEdiApiTypesSerializer Serializer { get; }

        protected const int DefaultTimeout = 30 * 1000;

        protected virtual Request BuildPostRequest<TContent>([NotNull] string relativeUrl, AuthCredentials authCredentials, string authToken, [CanBeNull] TContent content)
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

        protected virtual Request BuildGetRequest([NotNull] string relativeUrl, AuthCredentials authCredentials, string authToken)
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

        private string BuildAuthorizationHeader(AuthCredentials authCredentials, string authToken)
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
                stringBuilder.Append("," + $"konturediauth_portalsid={authCredentials.PortalSid}");
            }
            if (!string.IsNullOrEmpty(authCredentials?.Login))
            {
                stringBuilder.Append("," + $"konturediauth_login={authCredentials.Login},konturediauth_password={authCredentials.Password}");
            }

            return stringBuilder.ToString();
        }

        protected readonly IClusterClient clusterClient;

        private readonly string apiClientId;
    }
}