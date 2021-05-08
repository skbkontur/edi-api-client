using System;
using System.Globalization;
using System.Net;

using JetBrains.Annotations;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Internal;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents;
using SkbKontur.EdiApi.Client.Types.Parties;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;

using MessageBoxEventBatch = SkbKontur.EdiApi.Client.Types.Internal.MessageBoxEventBatch;

namespace SkbKontur.EdiApi.Client.Http.Internal
{
    public class InternalEdiApiHttpClient : BaseEdiApiHttpClient, IInternalEdiApiHttpClient
    {
        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeout, IWebProxy proxy = null, bool enableKeepAlive = true)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, enableKeepAlive)
        {
        }

        [CanBeNull]
        public Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId, bool includeRelatedDocuments = true)
        {
            var request = BuildGetRequest("V1/Internal/GetDocument", null, authToken)
                          .WithAdditionalQueryParameter("boxId", documentId.BoxId)
                          .WithAdditionalQueryParameter("entityId", documentId.EntityId)
                          .WithAdditionalQueryParameter("includeRelatedDocuments", includeRelatedDocuments.ToString());

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<Document>(result.Response.Content.ToString());
        }

        [NotNull]
        public MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, int? count = null)
        {
            var request = BuildGetRequest("V1/Internal/GetEvents", null, authToken);

            if (!string.IsNullOrWhiteSpace(exclusiveEventPointer))
            {
                request = request.WithAdditionalQueryParameter("exclusiveEventPointer", exclusiveEventPointer);
            }
            if (count.HasValue)
            {
                request = request.WithAdditionalQueryParameter("count", count.Value.ToString(CultureInfo.InvariantCulture));
            }

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEventBatch = Serializer.Deserialize<MessageBoxEventBatch>(result.Response.Content.ToString());
            foreach (var boxEvent in boxEventBatch.Events)
            {
                AdjustEventContent(boxEvent);
            }

            return boxEventBatch;
        }

        [NotNull]
        public MessageBoxEvent[] GetEventsByDocumentCirculationId([NotNull] string authToken, [NotNull] string documentCirculationId)
        {
            var request = BuildGetRequest("V1/Internal/GetEventsByDocumentCirculationId", null, authToken)
                .WithAdditionalQueryParameter("documentCirculationId", documentCirculationId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            var boxEvents = Serializer.Deserialize<MessageBoxEvent[]>(result.Response.Content.ToString());
            foreach (var boxEvent in boxEvents)
            {
                AdjustEventContent(boxEvent);
            }
            return boxEvents;
        }

        [NotNull]
        public string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime)
        {
            var request = BuildGetRequest("V1/Internal/GetLastEventPointer", null, authToken)
                .WithAdditionalQueryParameter("beforeDateTime", DateTimeUtils.ToString(beforeDateTime));

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return result.Response.Content.ToString();
        }

        [NotNull]
        public BoxesInfo GetBoxesInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetBoxesInfo", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxesInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public InternalPartyInfo GetInternalPartyInfo([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetInternalPartyInfo", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<InternalPartyInfo>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartyInfoWithEmployee[] GetPartiesByUser([NotNull] string authToken, [NotNull] string userId)
        {
            var request = BuildGetRequest("V1/Internal/GetPartiesByUser", null, authToken)
                .WithAdditionalQueryParameter("userId", userId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfoWithEmployee[]>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartyInfoWithEmployees[] GetPartiesInfoByInn([NotNull] string authToken, [NotNull] string partyInn)
        {
            var request = BuildGetRequest("V1/Internal/GetPartiesInfoByInn", null, authToken)
                .WithAdditionalQueryParameter("partyInn", partyInn);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfoWithEmployees[]>(result.Response.Content.ToString());
        }

        [NotNull]
        public PartySettings GetPartySettings([NotNull] string authToken, [NotNull] string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetPartySettings", null, authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartySettings>(result.Response.Content.ToString());
        }

        [NotNull]
        public string AddOrUpdateParty([NotNull] string authToken, [NotNull] string partyId, [NotNull] EditablePartySettings editablePartySettings)
        {
            var request = BuildPostRequest("V1/Internal/AddOrUpdateParty", null, authToken, editablePartySettings)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<string>(result.Response.Content.ToString());
        }

        public void AddEmployee([NotNull] string authToken, [NotNull] string partyId, [NotNull] string email)
        {
            var request = BuildPostRequest("V1/Internal/AddEmployee", null, authToken, Array.Empty<byte>())
                          .WithAdditionalQueryParameter("partyId", partyId)
                          .WithAdditionalQueryParameter("email", email);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void AddOrUpdateTradingPartnersSettings([NotNull] string authToken, [NotNull] EditableTradingPartnersSettings settingsToWrite)
        {
            var request = BuildPostRequest("V1/Internal/AddOrUpdateTradingPartnersSettings", null, authToken, settingsToWrite);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        private void AdjustEventContent(MessageBoxEvent boxEvent)
        {
            boxEvent.EventContent =
                boxEventTypeRegistry.IsSupportedEventType(boxEvent.EventType)
                    ? Serializer.NormalizeDeserializedObjectToType(boxEvent.EventContent, boxEventTypeRegistry.GetEventContentType(boxEvent.EventType))
                    : null;
        }

        private readonly IBoxEventTypeRegistry<MessageBoxEventType> boxEventTypeRegistry = new MessageBoxEventTypeRegistry();
    }
}