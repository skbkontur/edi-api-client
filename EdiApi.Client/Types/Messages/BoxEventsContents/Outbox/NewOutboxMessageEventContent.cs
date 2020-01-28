using SkbKontur.EdiApi.Client.Types.Boxes;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents.Outbox
{
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        public TransportType TransportType { get; set; }
    }
}