using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Internal.BoxEventsContents;
using KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox;
using KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox;

namespace KonturEdi.Api.Types.Internal.BoxEvents
{
    public class MessageBoxEventTypeRegistry : BoxEventTypeRegistry<MessageBoxEventType>
    {
        public MessageBoxEventTypeRegistry()
        {
            Register<MessageDraftOfDocumentPackagePostedIntoDiadocEventContent>(MessageBoxEventType.DraftOfDocumentPackagePostedIntoDiadoc);
            Register<MessageDraftOfDocumentPackagePostedIntoDiadocEventContent>(MessageBoxEventType.DraftOfDocumentPackagePostedIntoDiadoc);

            Register<MessageDraftOfDocumentPackageSignedByMeEventContent>(MessageBoxEventType.DraftOfDocumentPackageSignedByMe);
            Register<MessageDraftOfDocumentPackageSignedBySenderEventContent>(MessageBoxEventType.DraftOfDocumentPackageSignedBySender);
            Register<MessageDraftOfDocumentPackageDeletedFromDiadocEventContent>(MessageBoxEventType.DraftOfDocumentPackageDeletedFromDiadoc);
            Register<MessageReceivedDiadocRoamingErrorEventContent>(MessageBoxEventType.ReceivedDiadocRoamingError);

            Register<NewOutboxMessageEventContent>(MessageBoxEventType.NewOutboxMessage);
            Register<MessageCheckingOkEventContent>(MessageBoxEventType.MessageCheckingOk);
            Register<MessageCheckingFailEventContent>(MessageBoxEventType.MessageCheckingFail);
            Register<MessageReadByPartnerEventContent>(MessageBoxEventType.MessageReadByPartner);
            Register<MessageDeliveredEventContent>(MessageBoxEventType.MessageDelivered);
            Register<MessageUndeliveredEventContent>(MessageBoxEventType.MessageUndelivered);

            Register<RecognizeMessageEventContent>(MessageBoxEventType.RecognizeMessage);

            Register<NewOutboxDocumentEventContent>(MessageBoxEventType.NewOutboxDocument);
            Register<NewInboxDocumentEventContent>(MessageBoxEventType.NewInboxDocument);
        }
    }
}