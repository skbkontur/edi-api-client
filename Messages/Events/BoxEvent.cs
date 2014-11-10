using System;

namespace KonturEdi.Api.Types.Messages.Events
{
    public class BoxEvent
    {
        public string BoxId { get; set; }
        public string EventId { get; set; }
        public DateTime EventDateTime { get; set; }
        public BoxEventType EventType { get; set; }
        public object EventContent { get; set; }
    }

    public class BoxEvent<TEventContent> : ITypedBoxEvent
        where TEventContent : IBoxEventContent
    {
        public BoxEvent ToBoxEvent()
        {
            return new BoxEvent
                {
                    BoxId = BoxId,
                    EventContent = EventContent,
                    EventDateTime = EventDateTime,
                    EventId = EventId,
                    EventType = EventType,
                };
        }

        public IBoxEventContent GetEventContent()
        {
            return EventContent;
        }

        public string BoxId { get; set; }
        public string EventId { get; set; }
        public DateTime EventDateTime { get; set; }
        public BoxEventType EventType { get; set; }
        public TEventContent EventContent { get; set; }
    }

    public interface ITypedBoxEvent
    {
        BoxEvent ToBoxEvent();
        IBoxEventContent GetEventContent();
    }

    public interface IBoxEventContent
    {
        bool IsEmpty();
    }
}