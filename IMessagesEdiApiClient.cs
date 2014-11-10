using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEvents;

namespace KonturEdi.Api.Client
{
    public interface IMessagesEdiApiClient : IBaseEdiApiClient<MessageBoxEventBatch, MessageBoxEventType, MessageBoxEvent>
    {
        BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId);
        InboxMessageEntity GetInboxMessage(string authToken, string boxId, string messageId);
        OutboxMessageEntity GetOutboxMessage(string authToken, string boxId, string messageId);
        OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData);
    }
}