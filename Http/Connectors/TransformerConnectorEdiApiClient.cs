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

        public void TakenToTransformation(string authToken, string boxId, string connectorInteractionId)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TakenToTransformation")
                .AddParameter(BoxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .ToUri();
            MakeGetRequest(url, authToken);
        }

        public MessageMeta TransformedSuccessfully(string authToken, string boxId, string connectorInteractionId, MessageData resultMessageData)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TransformedSuccessfully")
                .AddParameter(BoxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .AddParameter("messageFileName", resultMessageData.MessageFileName)
                .ToUri();
            return MakePostRequest<MessageMeta>(url, authToken, resultMessageData.MessageBody);
        }

        public void TransformedUnsuccessfully(string authToken, string boxId, string connectorInteractionId, string[] errors)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "TransformedUnsuccessfully")
                .AddParameter(BoxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .ToUri();
            MakePostRequest(url, authToken, errors);
        }

        protected override string RelativeUrl { get { return "V1/Connectors/Transformers/"; } }
        private const string connectorInteractionIdUrlParameterName = "connectorInteractionId";
    }
}