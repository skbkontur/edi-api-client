using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    /// <summary>Информация о событии NewOutboxMessage</summary>
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        /// <summary>Тип транспорта</summary>
        public TransportType TransportType { get; set; }
    }
}