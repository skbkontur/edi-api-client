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
        public Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId, bool includeRelatedDocuments = true)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetDocument")
                      .AddParameter("boxId", documentId.BoxId)
                      .AddParameter("entityId", documentId.EntityId)
                      .AddParameter("includeRelatedDocuments", includeRelatedDocuments.ToString())
                      .ToUri();
            return MakeGetRequest<Document>(url, authToken);
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, int? count = null)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEvents");
            if (!string.IsNullOrWhiteSpace(exclusiveEventPointer))
                url.AddParameter("exclusiveEventPointer", exclusiveEventPointer);
            if (count.HasValue)
                url.AddParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            var boxEventBatch = MakeGetRequest<MessageBoxEventBatch>(url.ToUri(), authToken);
            boxEventBatch.Events = boxEventBatch.Events ?? new MessageBoxEvent[0];
            foreach (var boxEvent in boxEventBatch.Events)
                AdjustEventContent(boxEvent);
            return boxEventBatch;
        }

        [NotNull]
        public MessageBoxEvent[] GetEventsByDocumentCirculationId([NotNull] string authToken, [NotNull] string documentCirculationId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetEventsByDocumentCirculationId")
                .AddParameter("documentCirculationId", documentCirculationId);
            var boxEvents = MakeGetRequest<MessageBoxEvent[]>(url.ToUri(), authToken);
            foreach (var boxEvent in boxEvents)
                AdjustEventContent(boxEvent);
            return boxEvents;
        }

        [NotNull]
        public string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetLastEventPointer")
                .AddParameter("beforeDateTime", DateTimeUtils.ToString(beforeDateTime));
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

        [NotNull]
        public PartyInfoWithEmployee[] GetPartiesByUser([NotNull] string authToken, [NotNull] string userId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetPartiesByUser")
                      .AddParameter("userId", userId)
                      .ToUri();
            return MakeGetRequest<PartyInfoWithEmployee[]>(url, authToken);
        }

        [NotNull]
        public PartyInfoWithEmployees[] GetPartiesInfoByInn([NotNull] string authToken, [NotNull] string partyInn)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetPartiesInfoByInn")
                      .AddParameter("partyInn", partyInn)
                      .ToUri();
            return MakeGetRequest<PartyInfoWithEmployees[]>(url, authToken);
        }

        [NotNull]
        public PartySettings GetPartySettings([NotNull] string authToken, [NotNull] string partyId)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "GetPartySettings")
                      .AddParameter("partyId", partyId)
                      .ToUri();
            return MakeGetRequest<PartySettings>(url, authToken);
        }

        [NotNull]
        public string AddOrUpdateParty([NotNull] string authToken, [NotNull] string partyId, [NotNull] EditablePartySettings editablePartySettings)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "AddOrUpdateParty")
                .AddParameter("partyId", partyId);
            return MakePostRequest<EditablePartySettings, string>(url.ToUri(), authToken, editablePartySettings);
        }

        public void AddEmployee([NotNull] string authToken, [NotNull] string partyId, [NotNull] string email)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "AddEmployee")
                      .AddParameter("partyId", partyId)
                      .AddParameter("email", email);
            MakeGetRequest(url.ToUri(), authToken);
        }

        public void AddOrUpdateTradingPartnersSettings([NotNull] string authToken, [NotNull] EditableTradingPartnersSettings settingsToWrite)
        {
            var url = new UrlBuilder(BaseUri, relativeUrl + "AddOrUpdateTradingPartnersSettings");
            MakePostRequest(url.ToUri(), authToken, settingsToWrite);
        }

        private void AdjustEventContent(MessageBoxEvent boxEvent)
        {
            boxEvent.EventContent =
                boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                    ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                    : null;
        }

        private const string relativeUrl = "V1/Internal/";
        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}