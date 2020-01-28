using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Messages
{
    public class OutboxMessageEntity
    {
        public OutboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}