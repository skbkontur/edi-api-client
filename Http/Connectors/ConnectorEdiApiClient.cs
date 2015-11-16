using System;
using System.Net;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Connectors
{
    public abstract class ConnectorEdiApiClient : BaseEdiApiHttpClient, IConnectorEdiApiClient
    {
        protected ConnectorEdiApiClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds, IWebProxy proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public MessageEntity GetMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetMessage")
                .AddParameter(BoxIdUrlParameterName, boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<MessageEntity>(url, authToken);
        }

        public ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken)
        {
            var url = new UrlBuilder(BaseUri, "V1/Boxes/GetConnectorBoxesInfo").ToUri();
            return MakeGetRequest<ConnectorBoxesInfo>(url, authToken);
        }

        protected override string BoxIdUrlParameterName { get { return "connectorBoxId"; } }
    }
}