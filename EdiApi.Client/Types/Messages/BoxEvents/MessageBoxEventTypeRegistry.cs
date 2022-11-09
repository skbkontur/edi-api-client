using SkbKontur.EdiApi.Client.Types.BoxEvents;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Inbox;
using SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEvents
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
            Register<MessageDiadocRevocationRequestedEventContent>(MessageBoxEventType.DiadocRevocationRequested);
            Register<NewInboxDocumentEventContent>(MessageBoxEventType.NewInboxDocument);
            Register<ProcessingTimesReportEventContent>(MessageBoxEventType.ProcessingTimesReport);
            Register<MessageDocumentPackageSignedByRecipientOkEventContent>(MessageBoxEventType.DocumentPackageSignedByRecipientOk);
            Register<MessageDocumentPackageSignedByMeOkEventContent>(MessageBoxEventType.DocumentPackageSignedByMeOk);
            Register<MessageDocumentPackageSignedByRecipientFailEventContent>(MessageBoxEventType.DocumentPackageSignedByRecipientFail);
            Register<MessageDocumentPackageSignedByMeFailEventContent>(MessageBoxEventType.DocumentPackageSignedByMeFail);
            Register<AmendmentRequestedEventContent>(MessageBoxEventType.AmendmentRequested);
            Register<DiadocDocumentDeliveredEventContent>(MessageBoxEventType.DiadocDocumentDelivered);
            Register<MessageDocumentPackageSignedByRecipientPartiallyOkEventContent>(MessageBoxEventType.DocumentPackageSignedByRecipientPartiallyOk);
            Register<MessageDocumentPackageSignedByMePartiallyOkEventContent>(MessageBoxEventType.DocumentPackageSignedByMePartiallyOk);
            Register<OutboxDiadocDocumentRecipientPowerOfAttorneyStatusChangedEventContent>(MessageBoxEventType.OutboxDiadocDocumentRecipientPowerOfAttorneyStatusChanged);
            Register<OutboxDiadocDocumentSenderPowerOfAttorneyStatusChangedEventContent>(MessageBoxEventType.OutboxDiadocDocumentSenderPowerOfAttorneyStatusChanged);
            Register<InboxDiadocDocumentRecipientPowerOfAttorneyStatusChangedEventContent>(MessageBoxEventType.InboxDiadocDocumentRecipientPowerOfAttorneyStatusChanged);
            Register<InboxDiadocDocumentSenderPowerOfAttorneyStatusChangedEventContent>(MessageBoxEventType.InboxDiadocDocumentSenderPowerOfAttorneyStatusChanged);
            Register<OutboxDiadocDocumentSendingToGisMtEventContent>(MessageBoxEventType.OutboxDiadocDocumentSendingToGisMt);
            Register<InboxDiadocDocumentSendingToGisMtEventContent>(MessageBoxEventType.InboxDiadocDocumentSendingToGisMt);
            Register<OutboxDiadocDocumentIsProcessedInGisMtEventContent>(MessageBoxEventType.OutboxDiadocDocumentIsProcessedInGisMt);
            Register<InboxDiadocDocumentIsProcessedInGisMtEventContent>(MessageBoxEventType.InboxDiadocDocumentIsProcessedInGisMt);
            Register<OutboxDiadocDocumentSuccessProcessedInGisMtEventContent>(MessageBoxEventType.OutboxDiadocDocumentSuccessProcessedInGisMt);
            Register<InboxDiadocDocumentSuccessProcessedInGisMtEventContent>(MessageBoxEventType.InboxDiadocDocumentSuccessProcessedInGisMt);
            Register<OutboxDiadocDocumentProcessingFailInGisMtEventContent>(MessageBoxEventType.OutboxDiadocDocumentProcessingFailInGisMt);
            Register<InboxDiadocDocumentProcessingFailInGisMtEventContent>(MessageBoxEventType.InboxDiadocDocumentProcessingFailInGisMt);
            Register<OutboxDiadocRevocationSendingToGisMtEventContent>(MessageBoxEventType.OutboxDiadocRevocationSendingToGisMt);
            Register<InboxDiadocRevocationSendingToGisMtEventContent>(MessageBoxEventType.InboxDiadocRevocationSendingToGisMt);
            Register<OutboxDiadocRevocationIsProcessedInGisMtEventContent>(MessageBoxEventType.OutboxDiadocRevocationIsProcessedInGisMt);
            Register<InboxDiadocRevocationIsProcessedInGisMtEventContent>(MessageBoxEventType.InboxDiadocRevocationIsProcessedInGisMt);
            Register<OutboxDiadocRevocationSuccessProcessedInGisMtEventContent>(MessageBoxEventType.OutboxDiadocRevocationSuccessProcessedInGisMt);
            Register<InboxDiadocRevocationSuccessProcessedInGisMtEventContent>(MessageBoxEventType.InboxDiadocRevocationSuccessProcessedInGisMt);
            Register<OutboxDiadocRevocationProcessingFailInGisMtEventContent>(MessageBoxEventType.OutboxDiadocRevocationProcessingFailInGisMt);
            Register<InboxDiadocRevocationProcessingFailInGisMtEventContent>(MessageBoxEventType.InboxDiadocRevocationProcessingFailInGisMt);
        }
    }
}