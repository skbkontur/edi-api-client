using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEventsContents;

namespace KonturEdi.Api.Types.Messages.BoxEvents
{
    public class MessageBoxEventTypeRegistry : BoxEventTypeRegistry<MessageBoxEventType>
    {
        public MessageBoxEventTypeRegistry()
        {
            Register<NewOutboxMessageEventContent>(MessageBoxEventType.NewOutboxMessage);
            Register<NewInboxMessageEventContent>(MessageBoxEventType.NewInboxMessage);
            Register<MessageDeliveredEventContent>(MessageBoxEventType.MessageDelivered);
            Register<MessageReadByPartnerEventContent>(MessageBoxEventType.MessageReadByPartner);
            Register<MessageUndeliveredEventContent>(MessageBoxEventType.MessageUndelivered);
        }
    }
}