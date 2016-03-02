using System;

using JetBrains.Annotations;

using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEvents;

namespace KonturEdi.Api.Client
{
    public interface IMessagesEdiApiClient : IBaseEdiApiClient
    {
        [NotNull]
        BoxDocumentsSettings GetBoxDocumentsSettings([NotNull] string authToken, [NotNull] string boxId);

        [NotNull]
        MessageData GetMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId);

        [NotNull]
        InboxMessageMeta GetInboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId);

        [NotNull]
        OutboxMessageMeta GetOutboxMessageMeta([NotNull] string authToken, [NotNull] string boxId, [NotNull] string messageId);

        [NotNull]
        OutboxMessageMeta SendMessage([NotNull] string authToken, [NotNull] string boxId, [NotNull] MessageData messageData);

        [NotNull]
        MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, [CanBeNull] string exclusiveEventId, uint? count = null);

        [NotNull]
        MessageBoxEventBatch GetEvents([NotNull] string authToken, [NotNull] string boxId, DateTime fromDateTime, uint? count = null);
    }
}