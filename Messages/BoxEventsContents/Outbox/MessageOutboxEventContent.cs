using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class MessageOutboxEventContent : IBoxEventContent
    {
        public OutboxMessageMeta OutboxMessageMeta { get; set; }
    }
}