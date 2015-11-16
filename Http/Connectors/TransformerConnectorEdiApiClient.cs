using System;
using System.Globalization;
using System.Net;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Connectors.Transformer;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Connectors
{
    public class TransformerConnectorEdiApiClient : ConnectorEdiApiClient, ITransformerConnectorEdiApiClient
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

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetEvents")
                .AddParameter(BoxIdUrlParameterName, boxId)
                .AddParameter("exclusiveEventId", exclusiveEventId);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            return GetEvents(authToken, url);
        }

        public TransformerConnectorBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, RelativeUrl + "GetEventsFrom")
                .AddParameter(BoxIdUrlParameterName, boxId)
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
    }
}