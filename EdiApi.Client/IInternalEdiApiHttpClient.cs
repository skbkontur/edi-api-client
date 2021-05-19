using System;

using SkbKontur.EdiApi.Client.Types.Boxes;
using SkbKontur.EdiApi.Client.Types.Internal;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents;
using SkbKontur.EdiApi.Client.Types.Parties;

using MessageBoxEventBatch = SkbKontur.EdiApi.Client.Types.Internal.MessageBoxEventBatch;

#nullable enable

namespace SkbKontur.EdiApi.Client
{
    public interface IInternalEdiApiHttpClient
    {
        Document? GetDocument(string authToken, DocumentId documentId, bool includeRelatedDocuments = true);

        MessageBoxEventBatch GetEvents(string authToken, string? exclusiveEventPointer, int? count = null);

        MessageBoxEvent[] GetEventsByDocumentCirculationId(string authToken, string documentCirculationId);

        string GetLastEventPointer(string authToken, DateTime beforeDateTime);

        BoxesInfo GetBoxesInfo(string authToken, string partyId);

        InternalPartyInfo GetInternalPartyInfo(string authToken, string partyId);

        string AddOrUpdateParty(string authToken, string partyId, EditablePartySettings editablePartySettings);

        void AddEmployee(string authToken, string partyId, string email);

        void AddOrUpdateTradingPartnersSettings(string authToken, EditableTradingPartnersSettings settingsToWrite);
    }
}