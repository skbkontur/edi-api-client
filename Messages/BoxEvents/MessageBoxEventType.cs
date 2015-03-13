namespace KonturEdi.Api.Types.Messages.BoxEvents
{
    public enum MessageBoxEventType
    {
        Unknown,
        NewOutboxMessage,
        NewInboxMessage,
        MessageDelivered,
        MessageUndelivered,
        MessageReadByPartner,
        DraftOfDocumentPackagePostedIntoDiadoc,
        DraftOfDocumentPackageSignedByMe,
        DraftOfDocumentPackageDeletedFromDiadoc,
    }
}