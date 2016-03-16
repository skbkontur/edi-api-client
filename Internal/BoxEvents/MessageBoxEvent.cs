using System;

using KonturEdi.Api.Types.BoxEvents;
using KonturEdi.Api.Types.Messages.BoxEvents;

namespace KonturEdi.Api.Types.Internal.BoxEvents
{
    public abstract class MessageBoxEventBase<TEventContent>
    {
        public string BoxId { get; set; }
        public string EventPointer { get; set; }
        public DateTime EventDateTime { get; set; }
        public MessageBoxEventType EventType { get; set; }
        public TEventContent EventContent { get; set; }
    }

    public class MessageBoxEvent : MessageBoxEventBase<object>
    {
    }

    public class MessageBoxEvent<TEventContent> : MessageBoxEventBase<TEventContent>
        where TEventContent : IBoxEventContent
    {
    }
}