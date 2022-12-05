using System;

using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Messages;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;

#nullable enable

namespace SkbKontur.EdiApi.Client
{
    public interface IMessagesEdiApiClient : IBaseEdiApiClient
    {
        BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId);

        MessageData GetMessage(string authToken, string boxId, string messageId);

        InboxMessageMeta GetInboxMessageMeta(string authToken, string boxId, string messageId);

        OutboxMessageMeta GetOutboxMessageMeta(string authToken, string boxId, string messageId);

        OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData);

        OutboxMessageMeta SendMessageWithAttachments(string authToken, string boxId, MessageData messageData);

        MessageBoxEventBatch GetEvents(string authToken, string boxId, string? exclusiveEventId, uint? count = null);

        MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null);

        void MessageDeliveryStarted(string authToken, string boxId, string documentCirculationId);

        void MessageDeliveryFinished(string authToken, string boxId, string documentCirculationId, MessageDeliveryResult messageDeliveryResult);
    }
}