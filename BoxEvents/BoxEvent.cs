using System;

namespace KonturEdi.Api.Types.BoxEvents
{
    public abstract class BoxEvent<TBoxEventType>
        where TBoxEventType : struct
    {
        public string BoxId { get; set; }
        public string PartyId { get; set; }
        public string EventId { get; set; }
        public string EventPointer { get; set; }
        public DateTime EventDateTime { get; set; }
        public TBoxEventType EventType { get; set; }
        public object EventContent { get; set; }
    }
}