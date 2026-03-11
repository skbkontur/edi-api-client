using System;
using System.Threading.Tasks;

using SkbKontur.EdiApi.Client.Types.Common;
using SkbKontur.EdiApi.Client.Types.Messages;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;

#nullable enable

namespace SkbKontur.EdiApi.Client
{
    public interface IMessagesEdiApiClient : IBaseEdiApiClient
    {
        BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId);
        Task<BoxDocumentsSettings> GetBoxDocumentsSettingsAsync(string authToken, string boxId);

        MessageData GetMessage(string authToken, string boxId, string messageId);
        Task<MessageData> GetMessageAsync(string authToken, string boxId, string messageId);

        InboxMessageMeta GetInboxMessageMeta(string authToken, string boxId, string messageId);
        Task<InboxMessageMeta> GetInboxMessageMetaAsync(string authToken, string boxId, string messageId);

        OutboxMessageMeta GetOutboxMessageMeta(string authToken, string boxId, string messageId);
        Task<OutboxMessageMeta> GetOutboxMessageMetaAsync(string authToken, string boxId, string messageId);

        OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData);
        Task<OutboxMessageMeta> SendMessageAsync(string authToken, string boxId, MessageData messageData);

        MessageBoxEventBatch GetEvents(string authToken, string boxId, string? exclusiveEventId, uint? count = null);
        Task<MessageBoxEventBatch> GetEventsAsync(string authToken, string boxId, string? exclusiveEventId, uint? count = null);

        MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null);
        Task<MessageBoxEventBatch> GetEventsAsync(string authToken, string boxId, DateTime fromDateTime, uint? count = null);

        void MessageDeliveryStarted(string authToken, string boxId, string documentCirculationId);
        Task MessageDeliveryStartedAsync(string authToken, string boxId, string documentCirculationId);

        void MessageDeliveryFinished(string authToken, string boxId, string documentCirculationId, MessageDeliveryResult messageDeliveryResult);
        Task MessageDeliveryFinishedAsync(string authToken, string boxId, string documentCirculationId, MessageDeliveryResult messageDeliveryResult);
    }
}