using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using KonturEdi.Api.Client.Http.Helpers;
using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Internal;
using KonturEdi.Api.Types.Messages.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEventsContents;
using KonturEdi.Api.Types.Parties;
using KonturEdi.Api.Types.Serialization;

using MessageBoxEventBatch = KonturEdi.Api.Types.Internal.MessageBoxEventBatch;

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

        [CanBeNull]
        public Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetDocument")
                .AddParameter("boxId", documentId.BoxId)
                .AddParameter("entityId", documentId.EntityId)
                .ToUri();
            return MakeGetRequest<Document>(url, authToken);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, int? count = null)
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
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetLastEventPointer")
                .AddParameter("beforeDateTime", DateTimeUtils.ToString(beforeDateTime));
            return MakeGetRequestInternal(url.ToUri(), authToken);
        }

        [NotNull]
        [Obsolete("(avk): удалю после переезда на новые ленты событий")]
        public string GetFirstEventPointer([NotNull] string authToken, DateTime afterDateTime)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetFirstEventPointer")
                .AddParameter("afterDateTime", DateTimeUtils.ToString(afterDateTime));
            return MakeGetRequestInternal(url.ToUri(), authToken);
        }

        [NotNull]
        public BoxesInfo GetBoxesInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetBoxesInfo")
                .AddParameter("partyId", partyId);
            return MakeGetRequest<BoxesInfo>(url.ToUri(), authToken);
        }

        [NotNull]
        public InternalPartyInfo GetInternalPartyInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetInternalPartyInfo")
                .AddParameter("partyId", partyId);
            return MakeGetRequest<InternalPartyInfo>(url.ToUri(), authToken);
        }

        private const string relativeUrl = "V1/Internal/";
        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}