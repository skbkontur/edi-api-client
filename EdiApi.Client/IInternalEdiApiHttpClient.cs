using System;

using JetBrains.Annotations;

using SkbKontur.EdiApi.Types.Boxes;
using SkbKontur.EdiApi.Types.Internal;
using SkbKontur.EdiApi.Types.Messages.BoxEvents;
using SkbKontur.EdiApi.Types.Messages.BoxEventsContents;
using SkbKontur.EdiApi.Types.Parties;

using MessageBoxEventBatch = SkbKontur.EdiApi.Types.Internal.MessageBoxEventBatch;

namespace SkbKontur.EdiApi.Client
{
    [PublicAPI]
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