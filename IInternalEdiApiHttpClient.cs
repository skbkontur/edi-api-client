using System;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Internal;
using KonturEdi.Api.Types.Internal.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEventsContents;

namespace KonturEdi.Api.Client
{
    public interface IInternalEdiApiHttpClient
    {
        [NotNull]
        Document GetDocument([NotNull] string authToken, [NotNull] DocumentId documentId);

        [NotNull]
        MessageBoxEventBatch GetEvents([NotNull] string authToken, [CanBeNull] string exclusiveEventPointer, uint? count = null);

        [NotNull]
        string GetLastEventPointer([NotNull] string authToken, DateTime beforeDateTime);
    }
}