using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии ChildOutboxEntityMessage</summary>
    public class ChildOutboxEntityMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип транспорта</summary>
        public TransportType TransportType { get; set; }
    }
}