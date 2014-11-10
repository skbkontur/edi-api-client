namespace KonturEdi.Api.Types.Messages.Events
{
    public enum BoxEventType
    {
        Unknown,
        NewOutboxMessage,
        NewInboxMessage,
        MessageDelivered,
        MessageUndelivered,
        MessageReadByPartner
    }
}