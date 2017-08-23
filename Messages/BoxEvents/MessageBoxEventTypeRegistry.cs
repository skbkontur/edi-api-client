using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEventsContents;
using KonturEdi.Api.Types.Messages.BoxEventsContents.Inbox;
using KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox;

namespace KonturEdi.Api.Types.Messages.BoxEvents
{
    public class MessageBoxEventTypeRegistry : BoxEventTypeRegistry<MessageBoxEventType>
    {
        public MessageBoxEventTypeRegistry()
        {
            Register<NewOutboxMessageEventContent>(MessageBoxEventType.NewOutboxMessage);
            Register<NewInboxMessageEventContent>(MessageBoxEventType.NewInboxMessage);
            Register<RecognizeMessageEventContent>(MessageBoxEventType.RecognizeMessage);
            Register<NewOutboxDocumentEventContent>(MessageBoxEventType.NewOutboxDocument);
            Register<MessageDeliveredEventContent>(MessageBoxEventType.MessageDelivered);
            Register<MessageReadByPartnerEventContent>(MessageBoxEventType.MessageReadByPartner);
            Register<MessageUndeliveredEventContent>(MessageBoxEventType.MessageUndelivered);
            Register<MessageCheckingOkEventContent>(MessageBoxEventType.MessageCheckingOk);
            Register<MessageCheckingFailEventContent>(MessageBoxEventType.MessageCheckingFail);
            Register<MessageDraftOfDocumentPackagePostedIntoDiadocEventContent>(MessageBoxEventType.DraftOfDocumentPackagePostedIntoDiadoc);
            Register<MessageDraftOfDocumentPackageSignedByMeEventContent>(MessageBoxEventType.DraftOfDocumentPackageSignedByMe);
            Register<MessageDraftOfDocumentPackageSignedBySenderEventContent>(MessageBoxEventType.DraftOfDocumentPackageSignedBySender);
            Register<MessageDraftOfDocumentPackageDeletedFromDiadocEventContent>(MessageBoxEventType.DraftOfDocumentPackageDeletedFromDiadoc);
            Register<MessageReceivedDiadocRoamingErrorEventContent>(MessageBoxEventType.ReceivedDiadocRoamingError);
            Register<MessageDiadocRevocationAcceptedEventContent>(MessageBoxEventType.DiadocRevocationAccepted);
            Register<MessageDiadocRevocationAcceptedForBuyerEventContent>(MessageBoxEventType.DiadocRevocationAcceptedForBuyer);
            Register<NewInboxDocumentEventContent>(MessageBoxEventType.NewInboxDocument);
            Register<ProcessingTimesReportEventContent>(MessageBoxEventType.ProcessingTimesReport);
            Register<MessageDocumentPackageSignedByRecipientOkEventContent>(MessageBoxEventType.DocumentPackageSignedByRecipientOk);
            Register<MessageDocumentPackageSignedByMeOkEventContent>(MessageBoxEventType.DocumentPackageSignedByMeOk);
            Register<MessageDocumentPackageSignedByRecipientFailEventContent>(MessageBoxEventType.DocumentPackageSignedByRecipientFail);
            Register<MessageDocumentPackageSignedByMeFailEventContent>(MessageBoxEventType.DocumentPackageSignedByMeFail);
            Register<AmendmentRequestedEventContent>(MessageBoxEventType.AmendmentRequested);
            Register<DiadocDocumentDeliveredEventContent>(MessageBoxEventType.DiadocDocumentDelivered);
        }
    }
}