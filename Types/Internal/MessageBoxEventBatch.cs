using KonturEdi.Api.Types.Messages.BoxEvents;

namespace KonturEdi.Api.Types.Internal
{
    public class MessageBoxEventBatch
    {
        public MessageBoxEvent[] Events { get; set; }
        public string LastEventPointer { get; set; }
    }
}