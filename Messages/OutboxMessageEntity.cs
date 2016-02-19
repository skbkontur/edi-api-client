using KonturEdi.Api.Types.Common;

namespace KonturEdi.Api.Types.Messages
{
    public class OutboxMessageEntity
    {
        public OutboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}