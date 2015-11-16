using System;
using System.Globalization;
using System.Net;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors;
using KonturEdi.Api.Types.Connectors.Transformer;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Connectors
{
    public class TransformerConnectorEdiApiClient : BaseEdiApiHttpClient, ITransformerConnectorEdiApiClient
    {
        private readonly IBoxEventTypeRegistry<TransformerConnectorBoxEventType> boxEventTypeRegistry = new TransformerConnectorBoxEventTypeRegistry();

        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public TransformerConnectorEdiApiClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public void TakenToTransformation(string authToken, string boxId, string connectorInteractionId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "TakenToTransformation")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .ToUri();
            MakeGetRequest(url, authToken);
        }

        public MessageMeta TransformedSuccessfully(string authToken, string boxId, string connectorInteractionId, MessageData resultMessageData)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "TransformedSuccessfully")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .AddParameter("messageFileName", resultMessageData.MessageFileName)
                .ToUri();
            return MakePostRequest<MessageMeta>(url, authToken, resultMessageData.MessageBody);
        }

        public void TransformedUnsuccessfully(string authToken, string boxId, string connectorInteractionId, string[] errors)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "TransformedUnsuccessfully")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter(connectorInteractionIdUrlParameterName, connectorInteractionId)
                .ToUri();
            MakePostRequest(url, authToken, errors);
        }

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEventsFrom")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("fromDateTime", DateTimeUtils.ToString(fromDateTime));
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        private TransformerConnectorBoxEventBatch GetEvents(string authToken, UrlBuilder url)
        {
            var boxEventBatch = MakeGetRequest<TransformerConnectorBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new TransformerConnectorBoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }
            return boxEventBatch;
        }

        public MessageEntity GetMessage(string authToken, string boxId, string messageId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetMessage")
                .AddParameter(boxIdUrlParameterName, boxId)
                .AddParameter("messageId", messageId)
                .ToUri();
            return MakeGetRequest<MessageEntity>(url, authToken);
        }

        public ConnectorBoxesInfo GetConnectorBoxesInfo(string authToken)
        {
            var url = new UrlBuilder(BaseUri, "V1/Boxes/GetConnectorBoxesInfo").ToUri();
            return MakeGetRequest<ConnectorBoxesInfo>(url, authToken);
        }

        private const string relativeUrl = "V1/Connectors/Transformers/";
        private const string boxIdUrlParameterName = "connectorBoxId";
        private const string connectorInteractionIdUrlParameterName = "connectorInteractionId";
    }
}