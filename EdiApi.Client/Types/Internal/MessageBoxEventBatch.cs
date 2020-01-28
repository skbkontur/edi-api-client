using SkbKontur.EdiApi.Types.Messages.BoxEvents;

namespace SkbKontur.EdiApi.Types.Internal
{
    public class MessageBoxEventBatch
    {
        public MessageBoxEvent[] Events { get; set; }
        public string LastEventPointer { get; set; }
    }
}