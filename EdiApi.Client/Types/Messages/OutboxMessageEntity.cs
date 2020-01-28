using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    public class OutboxMessageEntity
    {
        public OutboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}