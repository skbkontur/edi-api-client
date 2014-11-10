namespace KonturEdi.Api.Types.Messages
{
    public class InboxMessageEntity
    {
        public InboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}