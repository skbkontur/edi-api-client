using KonturEdi.Api.Types.BoxEvents;

namespace KonturEdi.Api.Types.Messages.BoxEventsContents.Outbox
{
    public abstract class OutboxEventContentBase : IBoxEventContent
    {
        public BasicMessageMeta OutboxMessageMeta { get; set; }
    }
}