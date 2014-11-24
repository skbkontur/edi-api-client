using System;
using System.Net;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors.Transformer;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Connectors
{
    public class TransformerConnectorEdiApiClient : ConnectorEdiApiClient<TransformerConnectorBoxEventBatch, TransformerConnectorBoxEventType, TransformerConnectorBoxEvent>, ITransformerConnectorEdiApiClient
    {
        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(new TransformerConnectorBoxEventTypeRegistry(), apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public void TakenToTransformation(string authToken, string connectorBoxId, string connectorInteractionId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TakenToTransformation")
                .AddParameter("connectorBoxId", connectorBoxId)
                .AddParameter("connectorInteractionId", connectorInteractionId)
                .ToUri();
            MakeGetRequest(url, authToken);
        }

        public MessageMeta TransformedSuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, MessageData resultMessageData)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TransformedSuccessfully")
                .AddParameter("connectorBoxId", connectorBoxId)
                .AddParameter("connectorInteractionId", connectorInteractionId)
                .AddParameter("messageFileName", resultMessageData.MessageFileName)
                .ToUri();
            return MakePostRequest<MessageMeta>(url, authToken, resultMessageData.MessageBody);
        }

        public void TransformedUnsuccessfully(string authToken, string connectorBoxId, string connectorInteractionId, string[] errors)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TransformedUnsuccessfully")
                .AddParameter("connectorBoxId", connectorBoxId)
                .AddParameter("connectorInteractionId", connectorInteractionId)
                .ToUri();
            MakePostRequest(url, authToken, errors);
        }

        protected override string RelativeUrl { get { return "V1/Connectors/Transformers/"; } }
    }
}