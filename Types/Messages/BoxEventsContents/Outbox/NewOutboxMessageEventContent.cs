using SkbKontur.EdiApi.Types.Boxes;

namespace SkbKontur.EdiApi.Types.Messages.BoxEventsContents.Outbox
{
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        public TransportType TransportType { get; set; }
    }
}