using System;

namespace SkbKontur.EdiApi.Client.Types.BoxEvents
{
    public abstract class BoxEvent<TBoxEventType>
        where TBoxEventType : struct
    {
        /// <summary>Идентификатор ящика</summary>
        public string BoxId { get; set; }

        /// <summary>Идентификатор организации, которой принадлежит ящик</summary>
        public string PartyId { get; set; }

        /// <summary>Уникальный идентификатор события</summary>
        public string EventId { get; set; }

        /// <summary>Указатель на событие (следует передавать в exclusiveEventId)</summary>
        public string EventPointer { get; set; }

        /// <summary>Дата и время события</summary>
        public DateTime EventDateTime { get; set; }

        /// <summary>Тип события</summary>
        public TBoxEventType EventType { get; set; }

        /// <summary>Содержимое события (тип возвращаемого API объекта зависит непосредственно от типа события)</summary>
        public object EventContent { get; set; }
    }
}