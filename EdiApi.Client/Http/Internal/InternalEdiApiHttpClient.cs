using System;
using System.Globalization;
using System.Net;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Internal;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents;
using SkbKontur.EdiApi.Client.Types.Parties;
using SkbKontur.EdiApi.Client.Types.Serialization;

using Vostok.Clusterclient.Core;
using Vostok.Clusterclient.Core.Model;
using Vostok.Tracing.Abstractions;

using MessageBoxEventBatch = SkbKontur.EdiApi.Client.Types.Internal.MessageBoxEventBatch;

#nullable enable

namespace SkbKontur.EdiApi.Client.Http.Internal
{
    [Obsolete("Internal integrators should use Internal Api V2")]
    public class InternalEdiApiHttpClient : BaseEdiApiHttpClient, IInternalEdiApiHttpClient
    {
        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : this(apiClientId, baseUri, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, Uri baseUri, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null)
            : base(apiClientId, baseUri, serializer, timeoutInMilliseconds, proxy)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, string environment, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : this(apiClientId, environment, new JsonEdiApiTypesSerializer(), timeoutInMilliseconds, proxy, tracer)
        {
        }

        public InternalEdiApiHttpClient(string apiClientId, string environment, IEdiApiTypesSerializer serializer, int timeoutInMilliseconds = DefaultTimeoutMs, IWebProxy? proxy = null, ITracer? tracer = null)
            : base(apiClientId, environment, serializer, timeoutInMilliseconds, proxy, tracer)
        {
        }

        public Document? GetDocument(string authToken, DocumentId documentId, bool includeRelatedDocuments = true)
        {
            var request = BuildGetRequest("V1/Internal/GetDocument", authToken : authToken)
                          .WithAdditionalQueryParameter("boxId", documentId.BoxId)
                          .WithAdditionalQueryParameter("entityId", documentId.EntityId)
                          .WithAdditionalQueryParameter("includeRelatedDocuments", includeRelatedDocuments.ToString());

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<Document>(result.Response.Content.ToString());
        }

        public MessageBoxEventBatch GetEvents(string authToken, string? exclusiveEventPointer, int? count = null)
        {
            var request = BuildGetRequest("V1/Internal/GetEvents", authToken : authToken);

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

        public MessageBoxEvent[] GetEventsByDocumentCirculationId(string authToken, string documentCirculationId)
        {
            var request = BuildGetRequest("V1/Internal/GetEventsByDocumentCirculationId", authToken : authToken)
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

        public string GetLastEventPointer(string authToken, DateTime beforeDateTime)
        {
            var request = BuildGetRequest("V1/Internal/GetLastEventPointer", authToken : authToken)
                .WithAdditionalQueryParameter("beforeDateTime", DateTimeUtils.ToString(beforeDateTime));

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return result.Response.Content.ToString();
        }

        public BoxesInfo GetBoxesInfo(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetBoxesInfo", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<BoxesInfo>(result.Response.Content.ToString());
        }

        public InternalPartyInfo GetInternalPartyInfo(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetInternalPartyInfo", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<InternalPartyInfo>(result.Response.Content.ToString());
        }

        public PartyInfoWithEmployee[] GetPartiesByUser(string authToken, string userId)
        {
            var request = BuildGetRequest("V1/Internal/GetPartiesByUser", authToken : authToken)
                .WithAdditionalQueryParameter("userId", userId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfoWithEmployee[]>(result.Response.Content.ToString());
        }

        public PartyInfoWithEmployees[] GetPartiesInfoByInn(string authToken, string partyInn)
        {
            var request = BuildGetRequest("V1/Internal/GetPartiesInfoByInn", null, authToken)
                .WithAdditionalQueryParameter("partyInn", partyInn);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartyInfoWithEmployees[]>(result.Response.Content.ToString());
        }

        public PartySettings GetPartySettings(string authToken, string partyId)
        {
            var request = BuildGetRequest("V1/Internal/GetPartySettings", authToken : authToken)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<PartySettings>(result.Response.Content.ToString());
        }

        public string AddOrUpdateParty(string authToken, string partyId, EditablePartySettings editablePartySettings)
        {
            var request = BuildPostRequest("V1/Internal/AddOrUpdateParty", null, authToken, editablePartySettings)
                .WithAdditionalQueryParameter("partyId", partyId);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);

            return Serializer.Deserialize<string>(result.Response.Content.ToString());
        }

        public void AddEmployee(string authToken, string partyId, string email)
        {
            var request = BuildPostRequest("V1/Internal/AddEmployee", authToken : authToken)
                          .WithAdditionalQueryParameter("partyId", partyId)
                          .WithAdditionalQueryParameter("email", email);

            var result = clusterClient.Send(request);
            EnsureSuccessResult(result);
        }

        public void AddOrUpdateTradingPartnersSettings(string authToken, EditableTradingPartnersSettings settingsToWrite)
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