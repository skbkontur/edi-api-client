namespace KonturEdi.Api.Types.BoxEvents
{
    public class BoxEventBatch<TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
    {
        public TBoxEvent[] Events { get; set; }
        public string LastEventId { get; set; }
    }
}