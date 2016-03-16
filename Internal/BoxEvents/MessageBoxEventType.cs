namespace KonturEdi.Api.Types.Internal.BoxEvents
{
    public enum MessageBoxEventType
    {
        Unknown,
        NewOutboxMessage,
        RecognizeMessage,
        NewOutboxDocument,
        MessageDelivered,
        MessageUndelivered,
        MessageReadByPartner,
        MessageCheckingOk,
        MessageCheckingFail,
        DraftOfDocumentPackagePostedIntoDiadoc,
        DraftOfDocumentPackageSignedByMe,
        DraftOfDocumentPackageSignedBySender,
        DraftOfDocumentPackageDeletedFromDiadoc,
        ReceivedDiadocRoamingError,
        NewInboxDocument,
    }
}