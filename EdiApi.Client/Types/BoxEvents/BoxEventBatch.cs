namespace SkbKontur.EdiApi.Client.Types.BoxEvents
{
    /// <summary>Набор событий</summary>
    public class BoxEventBatch<TBoxEventType, TBoxEvent>
        where TBoxEventType : struct
        where TBoxEvent : BoxEvent<TBoxEventType>
    {
        /// <summary>Список событий</summary>
        public TBoxEvent[] Events { get; set; }
        /// <summary>Идентификатор последнего события в наборе (при следующем вызове метода GetEvents необходимо передать именно его)</summary>
        public string LastEventId { get; set; }
    }
}