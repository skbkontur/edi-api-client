using System;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.Internal;
using KonturEdi.Api.Types.Messages.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEventsContents;
using KonturEdi.Api.Types.Parties;

using MessageBoxEventBatch = KonturEdi.Api.Types.Internal.MessageBoxEventBatch;

namespace KonturEdi.Api.Client
{
    public interface IInternalEdiApiHttpClient
    {
        [CanBeNull]
        Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId, bool includeRelatedDocuments = true);

        [NotNull]
        MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, int? count = null);

        [NotNull]
        MessageBoxEvent[] GetEventsByDocumentCirculationId([NotNull] string authToken, [NotNull] string documentCirculationId);

        [NotNull]
        string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime);

        [NotNull]
        BoxesInfo GetBoxesInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        InternalPartyInfo GetInternalPartyInfo([NotNull] string authToken, [NotNull] string partyId);

        [NotNull]
        string AddOrUpdateParty([NotNull] string authToken, [NotNull] string partyId, [NotNull] EditablePartySettings editablePartySettings);

        void AddEmployee([NotNull] string authToken, [NotNull] string partyId, [NotNull] string email);

        void AddOrUpdateTradingPartnersSettings([NotNull] string authToken, [NotNull] EditableTradingPartnersSettings settingsToWrite);
    }
}