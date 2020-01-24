using SkbKontur.EdiApi.Types.Common;

namespace SkbKontur.EdiApi.Types.Messages
{
    public class InboxMessageEntity
    {
        public InboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}