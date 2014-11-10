namespace KonturEdi.Api.Types.Messages.Events
{
    public class BoxEventBatch
    {
        public BoxEvent[] Events { get; set; }
        public string LastEventId { get; set; }
    }
}