using SkbKontur.EdiApi.Client.Types.Messages.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Internal
{
    public class MessageBoxEventBatch
    {
        public MessageBoxEvent[] Events { get; set; }
        public string LastEventPointer { get; set; }
    }
}