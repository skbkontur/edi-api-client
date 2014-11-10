using System;
using System.Collections.Generic;
using System.Linq;

using KonturEdi.Api.Types.Messages.Events.EventContents;

namespace KonturEdi.Api.Types.Messages.Events
{
    public class BoxEventTypeRegistry
    {
        public BoxEventTypeRegistry()
        {
            Register<NewOutboxMessageEventContent>(BoxEventType.NewOutboxMessage);
            Register<NewInboxMessageEventContent>(BoxEventType.NewInboxMessage);
            Register<MessageDeliveredEventContent>(BoxEventType.MessageDelivered);
            Register<MessageReadByPartnerEventContent>(BoxEventType.MessageReadByPartner);
            Register<MessageUndeliveredEventContent>(BoxEventType.MessageUndelivered);
        }

        public Type[] GetAllTypes()
        {
            return eventTypeByType.Keys.ToArray();
        }

        public Type GetEventContentType(BoxEventType eventType)
        {
            if(!typeByEventType.ContainsKey(eventType))
                throw new Exception(string.Format("Unknown boxEventType {0}", eventType));
            return typeByEventType[eventType];
        }

        public BoxEventType GetEventContentType(Type eventContentType)
        {
            if(!eventTypeByType.ContainsKey(eventContentType))
                throw new Exception(string.Format("Unknown eventContentType {0}", eventContentType.FullName));
            return eventTypeByType[eventContentType];
        }

        private void Register<T>(BoxEventType eventType)
        {
            typeByEventType.Add(eventType, typeof(T));
            eventTypeByType.Add(typeof(T), eventType);
        }

        private readonly Dictionary<BoxEventType, Type> typeByEventType = new Dictionary<BoxEventType, Type>();
        private readonly Dictionary<Type, BoxEventType> eventTypeByType = new Dictionary<Type, BoxEventType>();
    }
}