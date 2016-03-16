namespace KonturEdi.Api.Types.Internal.BoxEvents
{
    public class MessageBoxEventBatch
    {
        public MessageBoxEvent[] Events { get; set; }
        public string LastEventPointer { get; set; }
    }
}