using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Internal;
using KonturEdi.Api.Types.Internal.BoxEvents;
using KonturEdi.Api.Types.Serialization;

namespace KonturEdi.Api.Client.Http.Internal
{
    public class InternalEdiApiHttpClient : BaseEdiApiHttpClient, IInternalEdiApiHttpClient
    {
        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        [NotNull]
        public Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetDocument")
                .AddParameter("boxId", documentId.BoxId)
                .AddParameter("entityId", documentId.EntityId)
                .ToUri();
            return MakeGetRequest<Document>(url, authToken);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, uint? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents");
            if(!string.IsNullOrWhiteSpace(exclusiveEventPointer))
                url.AddParameter("exclusiveEventPointer", exclusiveEventPointer);
            if(count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<MessageBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new MessageBoxEvent[0];
            foreach(var boxEvent in boxEventBatch.Events)
            {
                boxEvent.EventContent =
                    boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                        ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                        : null;
            }
            return boxEventBatch;
        }

        [NotNull]
        public string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents")
                .AddParameter("beforeDateTime", DateTimeUtils.ToString(beforeDateTime));
            return MakeGetRequest<string>(url.ToUri(), authToken);
        }

        private const string relativeUrl = "V1/Internal/";
        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}