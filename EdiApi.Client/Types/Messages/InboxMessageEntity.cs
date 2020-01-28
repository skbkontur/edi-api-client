using SkbKontur.EdiApi.Client.Types.Common;

namespace SkbKontur.EdiApi.Client.Types.Messages
{
    public class InboxMessageEntity
    {
        public InboxMessageMeta Meta { get; set; }
        public MessageData Data { get; set; }
    }
}