using KonturEdi.Api.Types.Boxes;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public class NewOutboxMessageEventContent : OutboxEventContentBase
    {
        public TransportType TransportType { get; set; }
    }
}