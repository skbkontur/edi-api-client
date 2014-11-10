using System;
using System.Collections.Generic;
using System.Linq;

namespace KonturEdi.Api.Types.BoxEvents
{
    public interface IBoxEventTypeRegistry<TBoxEventType>
    {
        bool IsSupportedEventContentType(Type eventContentType);
        bool IsSupportedEventType(TBoxEventType eventType);
        TBoxEventType GetEventType(Type eventContentType);
        Type GetEventContentType(TBoxEventType eventType);
        Type[] GetAllTypes();
    }

    public abstract class BoxEventTypeRegistry<TBoxEventType> : IBoxEventTypeRegistry<TBoxEventType>
    {
        public bool IsSupportedEventContentType(Type eventContentType)
        {
            return eventTypeByType.ContainsKey(eventContentType);
        }

        public bool IsSupportedEventType(TBoxEventType eventType)
        {
            return typeByEventType.ContainsKey(eventType);
        }

        public TBoxEventType GetEventType(Type eventContentType)
        {
            if(!IsSupportedEventContentType(eventContentType))
                throw new Exception(string.Format("Unknown eventContentType {0}", eventContentType.FullName));
            return eventTypeByType[eventContentType];
        }

        public Type GetEventContentType(TBoxEventType eventType)
        {
            if(!IsSupportedEventType(eventType))
                throw new Exception(string.Format("Unknown boxEventType {0}", eventType));
            return typeByEventType[eventType];
        }

        public Type[] GetAllTypes()
        {
            return eventTypeByType.Keys.ToArray();
        }

        protected void Register<T>(TBoxEventType eventType)
        {
            typeByEventType.Add(eventType, typeof(T));
            eventTypeByType.Add(typeof(T), eventType);
        }

        private readonly Dictionary<TBoxEventType, Type> typeByEventType = new Dictionary<TBoxEventType, Type>();
        private readonly Dictionary<Type, TBoxEventType> eventTypeByType = new Dictionary<Type, TBoxEventType>();
    }
}