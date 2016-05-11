using System;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Boxes;
using KonturEdi.Api.Types.Internal;
using KonturEdi.Api.Types.Messages.BoxEventsContents;

namespace KonturEdi.Api.Client
{
    public interface IInternalEdiApiHttpClient
    {
        [CanBeNull]
        Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId);

        [NotNull]
        MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, int? count = null);

        [NotNull]
        string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime);

        [NotNull]
        [Obsolete("(avk): удалю после переезда на новые ленты событий")]
        string GetFirstEventPointer([NotNull] string authToken, DateTime afterDateTime);

        [NotNull]
        BoxesInfo GetBoxesInfo([NotNull] string authToken, [NotNull] string partyId);
    }
}